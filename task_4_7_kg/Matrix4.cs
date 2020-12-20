using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_7_kg
{
    class Matrix4
    {
        private float[] matrix;
        public const int SIZE = 4;

        public Matrix4(float[][] matrix)
        {
            this.matrix = new float[16];
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    this.matrix[i * SIZE + j] = matrix[i][j];
        }
        public Matrix4(float[] matrix)
        {
            this.matrix = matrix;
        }

        public float GetFromIndex(int row, int column)
        {
            return matrix[row * SIZE + column];
        }
        public void SetFromIndex(int row, int column, float value)
        {
            matrix[row * SIZE + column] = value;
        }
        /**
       * Создает новую матрицу заполненную нулями 
       * @return нулевая матрица
       */
        public static Matrix4 ZeroMatrix()
        {
            return new Matrix4(new float[16]);
        }
        /**
         * Создает новую матрицу заполненную единицами на главной диагонали 
         * @return единичная матрица
         */
        public static Matrix4 IdentityMatrix()
        {
            Matrix4 matrix = ZeroMatrix();
            for (int i = 0; i < SIZE; i++)
            {
                matrix.SetFromIndex(i, i, 1);
            }
            return matrix;
        }
        public Matrix4 Multiplare(float number)
        {
            Matrix4 m = ZeroMatrix();
            for (int i = 0; i < this.matrix.Length; i++)
                m.matrix[i] = this.matrix[i] * number;

            return m;
        }
        public Vector4 Multiplare(Vector4 vector)
        {
            float[] result = new float[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                float sum = 0;
                for (int j = 0; j < SIZE; j++)
                {
                    sum += this.GetFromIndex(i, j) * vector.GetForIndex(j);
                }
                result[i] = sum;
            }
            return new Vector4(result[0], result[1], result[2], result[3]);
        }

        public Matrix4 Multiplare(Matrix4 other)
        {
            Matrix4 result = Matrix4.ZeroMatrix();
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    float sum = 0;
                    for (int k = 0; k < SIZE; k++)
                        sum += this.GetFromIndex(i, k) * other.GetFromIndex(k, j);
                    result.SetFromIndex(i, j, sum);
                }
            }
            return result;
        }
        public Matrix4 Addition(Matrix4 other)
        {
            Matrix4 result = Matrix4.ZeroMatrix();
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    result.SetFromIndex(j, j, this.GetFromIndex(i, j) + other.GetFromIndex(i, j));
            return result;
        }
    }
}
