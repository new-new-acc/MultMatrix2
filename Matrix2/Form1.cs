using System.Diagnostics;

namespace Matrix2
{
    public partial class Form1 : Form
    {




        private int debugCounter = 0;

        
        private int[,] matrA;
        private int[,] matrB;
        private int[,] matrC; 

        
        private int lastMatrixSize = 0;




        public Form1()
        {
            InitializeComponent();
        }





        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine("Нажата кнопка Generate");
            try
            {
                
                var rowsA_str = textBoxRowsA.Text.Trim();
                var colsA_str = textBoxColsA.Text.Trim();
                var rowsB_str = textBoxRowsB.Text.Trim();
                var colsB_str = textBoxColsB.Text.Trim();

                
                // for (int i = 0; i < 10; i++) { matrA[0, i] = i; }

                int rA = int.Parse(rowsA_str);
                int cA = int.Parse(colsA_str);
                int rB = int.Parse(rowsB_str);
                int cB = int.Parse(colsB_str);

                
                if (cA != rB)
                {
                    MessageBox.Show("Число столбцов A должно совпадать с числом строк B!");
                    return;
                }

                matrA = new int[rA, cA];
                matrB = new int[rB, cB];

                
                Random rnd = new Random();

                for (int i = 0; i < rA; i++)
                {
                    for (int j = 0; j < cA; j++)
                    {
                        matrA[i, j] = rnd.Next(1, 10);
                    }
                }

                for (int x = 0; x < rB; x++)
                {
                    for (int y = 0; y < cB; y++)
                    {
                        matrB[x, y] = rnd.Next(1, 10);
                    }
                }

                listBoxMatrixA.Items.Clear();
                listBoxMatrixB.Items.Clear();
                listBoxMatrixC.Items.Clear();

                
                listBoxMatrixA.Items.Add("Матрица A:");
                for (int i = 0; i < rA; i++)
                {
                    string rowStr = "";
                    for (int j = 0; j < cA; j++)
                    {
                        rowStr += matrA[i, j] + "\t";
                    }
                    listBoxMatrixA.Items.Add(rowStr);
                }

                listBoxMatrixA.Items.Add(" ");

               
                listBoxMatrixB.Items.Add("Matrix B:");
                for (int i = 0; i < rB; i++)
                {
                    var rowContent = "";
                    for (int j = 0; j < cB; j++)
                    {
                        rowContent += matrB[i, j] + "\t";
                    }
                    listBoxMatrixB.Items.Add(rowContent);
                }

                listBoxMatrixB.Items.Add("");

                labelSequentialTime.Text = "Время (последовательно): -";
                labelParallelTime.Text = "Время (параллельно): -";

                lastMatrixSize = rA * cB; 
                debugCounter++;

                MessageBox.Show("Ура, матрицы сгенерированы!");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Ошибка при генерации: " + ex.Message);
            }
        }

      
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (matrA == null || matrB == null)
            {
                MessageBox.Show("Сначала сгенерируйте матрицы!");
                return;
            }

            if (matrA.GetLength(1) != matrB.GetLength(0))
            {
               
                MessageBox.Show("Размеры матриц не совпадают для умножения!");
                return;
            }

            
            Stopwatch watchSeq = Stopwatch.StartNew();
            matrC = MultiplySequential(matrA, matrB);
            watchSeq.Stop();
            long seqMs = watchSeq.ElapsedMilliseconds;

            
            Stopwatch watchPar = Stopwatch.StartNew();
            var cParallel = MultiplyParallel(matrA, matrB);
            watchPar.Stop();
            long parMs = watchPar.ElapsedMilliseconds;

           
            listBoxMatrixC.Items.Clear();
            listBoxMatrixC.Items.Add("Результат (C):");
            for (int i = 0; i < cParallel.GetLength(0); i++)
            {
                string rowString = "";
                for (int j = 0; j < cParallel.GetLength(1); j++)
                {
                    rowString += cParallel[i, j] + "\t";
                }
                listBoxMatrixC.Items.Add(rowString);
            }

            labelSequentialTime.Text = "Время (последовательно): " + seqMs + " мс";
            labelParallelTime.Text = "Время (параллельно): " + parMs + " мс";

           
            bool sameRes = CheckEquality(matrC, cParallel);
            if (!sameRes)
            {
                MessageBox.Show("ОЙ! Результаты не совпадают, где-то ошибка!");
            }
            else
            {
                
            }
        }

        
        private bool CheckEquality(int[,] first, int[,] second)
        {
            if (first.GetLength(0) != second.GetLength(0) ||
                first.GetLength(1) != second.GetLength(1))
            {
                return false;
            }
            for (int i = 0; i < first.GetLength(0); i++)
            {
                for (int j = 0; j < first.GetLength(1); j++)
                {
                    if (first[i, j] != second[i, j]) return false;
                }
            }
            return true;
        }

       
        
        private int[,] MultiplySequential(int[,] A, int[,] B)
        {
            var rA = A.GetLength(0);
            var cA = A.GetLength(1);
            int rB = B.GetLength(0);
            int cB = B.GetLength(1);

            int[,] res = new int[rA, cB];

            for (int i = 0; i < rA; i++)
            {
                for (int j = 0; j < cB; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < cA; k++)
                    {
                        sum += A[i, k] * B[k, j];
                    }
                    res[i, j] = sum;
                }
            }
            return res;
        }

        
        //private void Me()
       // {
            // 
            // Thread.Sleep(50);
//}

        private int[,] MultiplyParallel(int[,] A, int[,] B)
        {
           
            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int rowsB = B.GetLength(0);
            int colsB = B.GetLength(1);

            int[,] result = new int[rowsA, colsB];

            
            Task[] tasks = new Task[rowsA];

            for (int i = 0; i < rowsA; i++)
            {
                
                int rowIndex = i;
                tasks[rowIndex] = Task.Run(() =>
                {
                   
                    Thread.Sleep(10);

                    for (int j = 0; j < colsB; j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < colsA; k++)
                        {
                            sum += A[rowIndex, k] * B[k, j];
                        }
                        result[rowIndex, j] = sum;
                    }
                });
            }
            Task.WaitAll(tasks);

            return result;
        }
    








        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
