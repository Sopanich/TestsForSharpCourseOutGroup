namespace Lab1.HomeWorks
{
    /// <summary>
    /// Методы обработки массива.
    /// Исходные условия: Метод принимает исходный массив, и возвращает результат обработки
    /// </summary>
    public static class HomeWork1
    {
        /// <summary>
        /// В массиве целых чисел поменять местами максимальный отрицательный элемент и минимальный положительный.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны местами максимальный отрицательный элемент и минимальный положительный</returns>
        public static int[] Variant1(int[] temp)
        {
            int max = int.MaxValue;
            int min = 0;
            int minID = 0;
            int maxID = 0;
            int[] temp2 = temp;

            for (int i = 0; i < temp2.Length; i++)
            {
                if (temp2[i] < 0 && temp2[i] < min)
                {
                    minID = i;
                    min = temp2[i];
                }
                if (temp2[i] > 0 && temp2[i] < max)
                {
                    maxID = i;
                    max = temp2[i];
                }
            }
            if (min < 0 && max < int.MaxValue)
            {
                int a = temp2[minID];
                temp2[minID] = temp2[maxID];
                temp2[maxID] = a;
                return temp2;
            }
            else return temp;
        }

        /// <summary>
        /// В массиве целых чисел определить сумму элементов, состоящих на чётных позициях
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Сумма элементов, состоящих на чётных позициях массива</returns>
        public static int Variant2(int[] temp)
        {
            int sum = 0;
            for(int i = 2; i < temp.Length; i+=2)
            {
                sum += temp[i];
            }
            return sum;
        }

        /// <summary>
        /// В массиве целых чисел заменить нулями отрицательные элементы.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором поменяны отрицательные элементы на нули</returns>
        public static int[] Variant3(int[] temp)
        {
           for(int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < 0)
                {
                    temp[i] = 0;
                }
            }
            return temp;
        }

        /// <summary>
        /// В массиве целых чисел утроить каждый положительный элемент, который стоит перед отрицательным.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Массив в котором *3 каждый положительный элемент, который стоит перед отрицательным</returns>
        public static int[] Variant4(int[] temp)
        {
            for (int i = 1; i < temp.Length; i++){
                if(temp[i] < 0 && temp[i-1] > 0)
                {
                    temp[i - 1] *= 3;
                }
            }
            return temp;
        }

        /// <summary>
        /// В массиве целых чисел найти разницу между средним арифметическим и значение минимального элемента.
        /// </summary>
        /// <param name="temp">Исходный массив</param>
        /// <returns>Разница между средним арифметическим и значение минимального элемента</returns>
        public static double Variant5(int[] temp)
        {
            double sum = 0;
            double min = temp[0];
            for(int i = 0; i < temp.Length; i++)
            {
                sum += temp[i];
                if(temp[i] <  min)
                {
                    min = temp[i];
                }
            }
            double value = sum / temp.Length - min;
            return value;

        }
    }
}