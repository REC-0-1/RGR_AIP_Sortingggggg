using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR_AIP_Sorting
{
    public partial class Form1 : Form
    {
        public int VremyaPuzir1;
        public int VremyaPuzir2;
        public int VremyaPuzir3;
        public int VremyaPuzir4;
        public int VremyaPuzir5;
        public int VremyaVibor1;
        public int VremyaVibor2;
        public int VremyaVibor3;
        public int VremyaVibor4;
        public int VremyaVibor5;
        public int VremyaVstavka1;
        public int VremyaVstavka2;
        public int VremyaVstavka3;
        public int VremyaVstavka4;
        public int VremyaVstavka5;
        public int VremyaQuick1;
        public int VremyaQuick2;
        public int VremyaQuick3;
        public int VremyaQuick4;
        public int VremyaQuick5;
        public int VremyaShaker1;
        public int VremyaShaker2;
        public int VremyaShaker3;
        public int VremyaShaker4;
        public int VremyaShaker5;
        public int VremyaRass1;
        public int VremyaRass2;
        public int VremyaRass3;
        public int VremyaRass4;
        public int VremyaRass5;

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public void Graphics()
        {
            chart1.Series[0].Points.AddXY(1000, VremyaPuzir1);
            chart1.Series[0].Points.AddXY(2000, VremyaPuzir2);
            chart1.Series[0].Points.AddXY(5000, VremyaPuzir3);
            chart1.Series[0].Points.AddXY(10000, VremyaPuzir4);
            chart1.Series[0].Points.AddXY(15000, VremyaPuzir5);

            chart1.Series[3].Points.AddXY(1000, VremyaRass1);
            chart1.Series[3].Points.AddXY(2000, VremyaRass2);
            chart1.Series[3].Points.AddXY(5000, VremyaRass3);
            chart1.Series[3].Points.AddXY(10000, VremyaRass4);
            chart1.Series[3].Points.AddXY(15000, VremyaRass5);

            chart1.Series[2].Points.AddXY(1000, VremyaShaker1);
            chart1.Series[2].Points.AddXY(2000, VremyaShaker2);
            chart1.Series[2].Points.AddXY(5000, VremyaShaker3);
            chart1.Series[2].Points.AddXY(10000, VremyaShaker4);
            chart1.Series[2].Points.AddXY(15000, VremyaShaker5);

            chart1.Series[1].Points.AddXY(1000, VremyaVibor1);
            chart1.Series[1].Points.AddXY(2000, VremyaVibor2);
            chart1.Series[1].Points.AddXY(5000, VremyaVibor3);
            chart1.Series[1].Points.AddXY(10000, VremyaVibor4);
            chart1.Series[1].Points.AddXY(15000, VremyaVibor5);

            chart1.Series[4].Points.AddXY(1000, VremyaQuick1);
            chart1.Series[4].Points.AddXY(2000, VremyaQuick2);
            chart1.Series[4].Points.AddXY(5000, VremyaQuick3);
            chart1.Series[4].Points.AddXY(10000, VremyaQuick4);
            chart1.Series[4].Points.AddXY(15000, VremyaQuick5);
        }


        public List<Pomogite> Элементы { get; set; }        
        public Form1()
        {
            //hddddddd
            //Первый массив
            int[] Amas = new int[1000];
            Random rand = new Random();
            for (int i = 0; i < Amas.Length; i++)
            {
                Amas[i] = rand.Next(10, 1001);
            }
            //Второй массив
            int[] Bmas = new int[2000];
            for (int i = 0; i < Bmas.Length; i++)
            {
                Bmas[i] = rand.Next(10, 1001);
            }
            //Третий массив
            int[] Cmas = new int[5000];
            for (int i = 0; i < Cmas.Length; i++)
            {
                Cmas[i] = rand.Next(10, 1001);
            }
            //Четвёртый массив
            int[] Dmas = new int[10000];
            for (int i = 0; i < Dmas.Length; i++)
            {
                Dmas[i] = rand.Next(10, 1001);
            }
            //Пятый массив
            int[] Emas = new int[15000];
            for (int i = 0; i < Emas.Length; i++)
            {
                Emas[i] = rand.Next(10, 1001);

            }
            /// массивы расчески
            int[] Tmas = new int[4500000];
            for (int i = 0; i < Emas.Length; i++)
            {
                Emas[i] = rand.Next(10, 1001);
            }
            int[] Ymas = new int[3500000];
            for (int i = 0; i < Emas.Length; i++)
            {
                Emas[i] = rand.Next(10, 1001);
            }
            int[] Umas = new int[2500000];
            for (int i = 0; i < Emas.Length; i++)
            {
                Emas[i] = rand.Next(10, 1001);
            }
            int[] Imas = new int[1000000];
            for (int i = 0; i < Emas.Length; i++)
            {
                Emas[i] = rand.Next(10, 1001);
            }
            int[] Omas = new int[10000];
            for (int i = 0; i < Emas.Length; i++)
            {
                Emas[i] = rand.Next(10, 1001);
            }
            //Сортировка пузырьком
            //int A2 = 0, A3 = 0, A4 = 0, A5 = 0;
            var sw1 = new Stopwatch();
            sw1.Start();
            int[] Puz1000 = Puzirok(Amas);
            sw1.Stop();
            VremyaPuzir1 = sw1.Elapsed.Milliseconds;
            var sw2 = new Stopwatch();
            sw2.Start();
            int[] Puz2000 = Puzirok(Bmas);
            sw2.Stop();
            VremyaPuzir2 = sw2.Elapsed.Milliseconds;
            var sw3 = new Stopwatch();
            sw3.Start();
            int[] Puz5000 = Puzirok(Cmas);
            sw3.Stop();
            VremyaPuzir3 = sw3.Elapsed.Milliseconds;
            var sw4 = new Stopwatch();
            sw4.Start();
            int[] Puz10000 = Puzirok(Dmas);
            sw4.Stop();
            VremyaPuzir4 = sw4.Elapsed.Milliseconds;
            var sw5 = new Stopwatch();
            sw5.Start();
            int[] Puz15000 = Puzirok(Emas);
            sw5.Stop();
            VremyaPuzir5 = sw5.Elapsed.Milliseconds;
            //Сортировка выбором
            //////int B2 = 0, B3 = 0, B4=0, B5 = 0;
            var sp1 = new Stopwatch();
            sp1.Start();
            int[] Vib1000 = Vibor(Amas);
            sp1.Stop();
            VremyaVibor1 = sp1.Elapsed.Milliseconds;
            var sp2 = new Stopwatch();
            sp2.Start();
            int[] Vib2000 = Vibor(Bmas);
            sp2.Stop();
            VremyaVibor2 = sp2.Elapsed.Milliseconds;
            var sp3 = new Stopwatch();
            sp3.Start();
            int[] Vib5000 = Vibor(Cmas);
            sp3.Stop();
            VremyaVibor3 = sp3.Elapsed.Milliseconds;
            var sp4 = new Stopwatch();
            sp4.Start();
            int[] Vib10000 = Vibor(Dmas);
            sp4.Stop();
            VremyaVibor4 = sp4.Elapsed.Milliseconds;
            var sp5 = new Stopwatch();
            sp5.Start();
            int[] Vib15000 = Vibor(Emas);
            sp5.Stop();
            VremyaVibor5 = sp5.Elapsed.Milliseconds;
            //Сортировка расчёской
            var ns1 = new Stopwatch();
            ns1.Start();
            int[] Ras1000 = rassort(Omas);
            ns1.Stop();
            VremyaRass1 = ns1.Elapsed.Milliseconds;
            var ns2 = new Stopwatch();
            ns2.Start();
            int[] Ras2000 = rassort(Imas);
            ns2.Stop();
            VremyaRass2 = ns2.Elapsed.Milliseconds;
            var ns3 = new Stopwatch();
            ns3.Start();
            int[] Ras5000 = rassort(Umas);
            ns3.Stop();
            VremyaRass3 = ns3.Elapsed.Milliseconds;
            var ns4 = new Stopwatch();
            ns4.Start();
            int[] Ras10000 = rassort(Ymas);
            ns4.Stop();
            VremyaRass4 = ns4.Elapsed.Milliseconds;
            var ns5 = new Stopwatch();
            ns5.Start();
            int[] Ras15000 = rassort(Tmas);
            ns5.Stop();
            VremyaRass5 = ns5.Elapsed.Milliseconds;
            //Быстрая сортировка
            var sb1 = new Stopwatch();
            sb1.Start();
            int[] Quick1000 = QuickSort(Amas, 0, Amas.Length - 1);
            sb1.Stop();
            VremyaQuick1 = sb1.Elapsed.Milliseconds;
            var sb2 = new Stopwatch();
            sb2.Start();
            int[] Quick2000 = QuickSort(Bmas, 0, Bmas.Length - 1);
            sb2.Stop();
            VremyaQuick2 = sb2.Elapsed.Milliseconds;
            var sb3 = new Stopwatch();
            sb3.Start();
            int[] Quick5000 = QuickSort(Cmas, 0, Cmas.Length - 1);
            sb3.Stop();
            VremyaQuick3 = sb3.Elapsed.Milliseconds;
            var sb4 = new Stopwatch();
            sb4.Start();
            int[] Quick10000 = QuickSort(Dmas, 0, Dmas.Length - 1);
            sb4.Stop();
            VremyaQuick4 = sb4.Elapsed.Milliseconds;
            var sb5 = new Stopwatch();
            sb5.Start();
            int[] Quick15000 = QuickSort(Emas, 0, Emas.Length - 1);
            sb5.Stop();
            VremyaQuick5 = sb5.Elapsed.Milliseconds;
            //Шейкерная сортировка
            var sg1 = new Stopwatch();
            sg1.Start();
            int[] Shaker1000 = ShakerSort(Amas);
            sg1.Stop();
            VremyaShaker1 = sg1.Elapsed.Milliseconds;
            var sg2 = new Stopwatch();
            sg2.Start();
            int[] Shaker2000 = ShakerSort(Bmas);
            sg2.Stop();
            VremyaShaker2 = sg2.Elapsed.Milliseconds;
            var sg3 = new Stopwatch();
            sg3.Start();
            int[] Shaker5000 = ShakerSort(Cmas);
            sg3.Stop();
            VremyaShaker3 = sg3.Elapsed.Milliseconds;
            var sg4 = new Stopwatch();
            sg4.Start();
            int[] Shaker10000 = ShakerSort(Dmas);
            sg4.Stop();
            VremyaShaker4 = sg4.Elapsed.Milliseconds;
            var sg5 = new Stopwatch();
            sg5.Start();
            int[] Shaker15000 = ShakerSort(Emas);
            sg5.Stop();
            VremyaShaker5 = sg5.Elapsed.Milliseconds;
            Элементы = GetЭлементы();
            InitializeComponent();
            Graphics();

        }

        public List<Pomogite> GetЭлементы()
        {
            var list = new List<Pomogite>();
            list.Add(new Pomogite() 
            { 
                Элементы = 1000,
                пузырьком = VremyaPuzir1,
                выбором = VremyaVibor1,
                шейкерная = VremyaShaker1,
                быстрая = VremyaQuick1,

            });
            list.Add(new Pomogite()
            {
                Элементы = 2000,
                пузырьком = VremyaPuzir2,
                выбором = VremyaVibor2,
                шейкерная = VremyaShaker2,
                быстрая = VremyaQuick2,

            });
            list.Add(new Pomogite()
            {
                Элементы = 5000,
                пузырьком = VremyaPuzir3,
                выбором = VremyaVibor3,
                шейкерная = VremyaShaker3,
                быстрая = VremyaQuick3,

            });
            list.Add(new Pomogite()
            {
                Элементы = 10000,
                пузырьком = VremyaPuzir4,
                выбором = VremyaVibor4,
                шейкерная = VremyaShaker4,
                быстрая = VremyaQuick4,

            });
            list.Add(new Pomogite()
            {
                Элементы = 15000,
                пузырьком = VremyaPuzir5,
                выбором = VremyaVibor5,
                шейкерная = VremyaShaker5,
                быстрая = VremyaQuick5,

            });
            list.Add(new Pomogite()
            {
                Элементы = 0,
                пузырьком = 0,
                выбором = 0,
                шейкерная = 0,
                быстрая = 0,
                расчёской = 0,

            });
            list.Add(new Pomogite()
            {
                Элементы = 10000,
                расчёской = VremyaRass1,

            });
            list.Add(new Pomogite()
            {
                Элементы = 1000000,
                расчёской = VremyaRass2,

            });
            list.Add(new Pomogite()
            {
                Элементы = 2500000,
                расчёской = VremyaRass3,

            });
            list.Add(new Pomogite()
            {
                Элементы = 3500000,
                расчёской = VremyaRass4,

            });
            list.Add(new Pomogite()
            {
                Элементы = 4500000,
                расчёской = VremyaRass5,

            });


            return list;
        }

        public int[] Puzirok(int[] A) // Сортировка пузырьком
        {
            
            int temp;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - 1 - i; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                    
                }
            }



            return A;
        }
        public int[] Vibor(int[]B)// Сортировка выбором
        {


            for (int i=0;i<B.Length;i++)
            {
                int minIndex = i;
                for(int j=i;j<B.Length;j++)
                {
                    if(B[minIndex]>B[j])
                    {
                        minIndex = j;
                    }
                }
                int k = B[i];
                B[i] = B[minIndex];
                B[minIndex] = k;
            }



            return B;
        }
        public int[]ShakerSort(int[]mas)// Шейкерная сортировка
        {
            for (int i = 0; i < mas.Length / 2; i++)
            {
                bool swap = false;
                for (int j = i; j < mas.Length - i - 1; j++)
                {
                    if (mas[j] < mas[j + 1])
                    {
                        int val = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = val;
                        swap = true;
                    }
                }
                for (int j = mas.Length - 2 - i; j > i; j--)
                {
                    if (mas[j] > mas[j - 1])
                    {
                        int val = mas[j];
                        mas[j] = mas[j - 1];
                        mas[j - 1] = val;
                        swap = true;
                    }
                }
                if (swap == false)
                {
                    break;
                }
            }
            return mas;
        }

    
        static int FindPivot(int[]E, int minIndex, int maxIndex)//метод создающий опортую переменную
        {
            int pivot = minIndex-1; // опора
            int temp2 = 0;
            for(int i = minIndex; i < maxIndex;i++)
            {
                if (E[i] < E[maxIndex])
                {
                    pivot++;
                    temp2 = E[pivot];
                    E[pivot] = E[i];
                    E[i] = temp2;
                }
            }
            pivot++;
            temp2 = E[pivot];
            E[pivot] = E[maxIndex];
            E[maxIndex] = temp2;

            return pivot;
        }
        static int[] QuickSort(int[]E, int minIndex, int maxIndex)// Быстрая сортировка
        {
            var stopWatch = Stopwatch.StartNew();
            int E1;
            if (minIndex>=maxIndex)
            {
                return E;
            }
            int pivot = FindPivot(E, minIndex, maxIndex);
            QuickSort(E, minIndex, pivot - 1);
            QuickSort(E, pivot + 1, maxIndex);

            stopWatch.Stop();
            E1 = stopWatch.Elapsed.Milliseconds;

            return E;
        }
        public int[] rassort(int[] mas) // Расчёской
        {

            int gap = mas.Length;
            bool swap = true;
            while (gap > 1 || swap == true)
            {
                gap = gap / 12;
                if (gap < 1)
                {
                    gap = 1;
                }
                int i = 0;
                swap = false;
                while (i + gap < mas.Length)
                {
                    int igap = i + (int)gap;
                    if (mas[i] > mas[igap])
                    {
                        int val = mas[i];
                        mas[i] = mas[igap];
                        mas[igap] = val;
                        swap = true;
                    }
                    i++;
                }
            }
            return mas;
        }
        public int[]Vstavka(int[]D)// Сортировка вставками
        {

            for(int i=0; i<D.Length;i++)
            {

                int k = D[i];
                int j = i - 1;
                while (j >= 0 && D[j]>k)
                {
                    D[j + 1] = D[j];
                    D[j] = k;
                    j--;
                }
            }
            return D;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var pomogite = this.Элементы;
            dataGridView1.DataSource = pomogite;

        }
    }
}
