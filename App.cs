using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_veru_chto_eto_Konec
{

    public partial class App : Form
    {
        static int INF = int.MaxValue;
        static int[,] adjacencyMatrix;
        static int FindShortestPath(int[] path, int[] minPath, int index, int numOfCities)
        {
            if (index == numOfCities)
            {
                int distance = CalculateDistance(path, numOfCities);
                if (distance < INF)
                {
                    Array.Copy(path, minPath, numOfCities);
                }
                return distance;
            }

            int minDistance = INF;
            for (int i = index; i < numOfCities; i++)
            {
                Swap(ref path[index], ref path[i]);
                int currentDistance = FindShortestPath(path, minPath, index + 1, numOfCities);
                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                }
                Swap(ref path[index], ref path[i]);
            }

            return minDistance;
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static int CalculateDistance(int[] path, int numOfCities)
        {
            int distance = 0;
            for (int i = 0; i < numOfCities - 1; i++)
            {
                int fromCity = path[i];
                int toCity = path[i + 1];
                distance += adjacencyMatrix[fromCity, toCity];
            }
            distance += adjacencyMatrix[path[numOfCities - 1], path[0]];
            return distance;
        }

        public App()
        {
            InitializeComponent();
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Answer.Clear();

            AB.Clear();
            AC.Clear();
            AD.Clear();
            AE.Clear();
           
            BA.Clear();
            BC.Clear();
            BD.Clear();
            BE.Clear();

            CA.Clear();
            CB.Clear();
            CD.Clear();
            CE.Clear();

            DA.Clear();
            Db.Clear();
            DC.Clear();
            DE.Clear();

            EA.Clear();
            EB.Clear();
            EC.Clear();
            ED.Clear();


        }

        private void Creat_Work_Click(object sender, EventArgs e)
        {
            if (AB.Text == "")
            {
                MessageBox.Show("заполните города");
                return;
            }
            if (AB.Text == "[A-Я]")
            {
                MessageBox.Show("заполните города");
                return;
            }
            int numOfCities = 5;
            adjacencyMatrix = new int[numOfCities, numOfCities];
 
            adjacencyMatrix[0, 0] = 0;
            adjacencyMatrix[0, 1] = Convert.ToInt32(AB.Text);
            adjacencyMatrix[0, 2] = Convert.ToInt32(AC.Text);
            adjacencyMatrix[0, 3] = Convert.ToInt32(AD.Text);
            adjacencyMatrix[0, 4] = Convert.ToInt32(AE.Text);
            adjacencyMatrix[1, 0] = Convert.ToInt32(BA.Text);
            adjacencyMatrix[1, 1] = 0;
            adjacencyMatrix[1, 2] = Convert.ToInt32(BC.Text);
            adjacencyMatrix[1, 3] = Convert.ToInt32(BD.Text);
            adjacencyMatrix[1, 4] = Convert.ToInt32(BE.Text); 
            adjacencyMatrix[2, 0] = Convert.ToInt32(CA.Text);
            adjacencyMatrix[2, 1] = Convert.ToInt32(CB.Text);
            adjacencyMatrix[2, 2] = 0;
            adjacencyMatrix[2, 3] = Convert.ToInt32(CD.Text);
            adjacencyMatrix[2, 4] = Convert.ToInt32(CE.Text);
            adjacencyMatrix[3, 0] = Convert.ToInt32(DA.Text);
            adjacencyMatrix[3, 1] = Convert.ToInt32(Db.Text);
            adjacencyMatrix[3, 2] = Convert.ToInt32(DC.Text);
            adjacencyMatrix[3, 3] = 0;
            adjacencyMatrix[3, 4] = Convert.ToInt32(DE.Text);
            adjacencyMatrix[4, 0] = Convert.ToInt32(EA.Text);
            adjacencyMatrix[4, 1] = Convert.ToInt32(EB.Text);
            adjacencyMatrix[4, 2] = Convert.ToInt32(EC.Text);
            adjacencyMatrix[4, 3] = Convert.ToInt32(ED.Text);
            adjacencyMatrix[4, 4] = 0;

           

        }

        private void Way_button_Click(object sender, EventArgs e)
        {
            int[] path = new int[5];
            for (int i = 0; i < 5; i++)
            {
                path[i] = i;
            }

            int[] minPath = new int[5];
            int minDistance = FindShortestPath(path, minPath, 1, 5 - 1);


            Answer.Text +=(minDistance);
        }
    }
}
