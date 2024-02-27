namespace Csharp4
{
    public class Matrix
    {
        private int[,] data;
        public int Rows { get; }
        public int Columns { get; }

        public int this[int i, int j]
        {
            get { return data[i, j]; }
            set { data[i, j] = value; }
        }

        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            data = new int[rows, columns];
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
                throw new ArgumentException("Matrices must have the same dimensions");

            Matrix result = new Matrix(m1.Rows, m1.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
                throw new ArgumentException("Matrices must have the same dimensions");

            Matrix result = new Matrix(m1.Rows, m1.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix m, int scalar)
        {
            Matrix result = new Matrix(m.Rows, m.Columns);

            for (int i = 0; i < m.Rows; i++)
            {
                for (int j = 0; j < m.Columns; j++)
                {
                    result[i, j] = m[i, j] * scalar;
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.Columns != m2.Rows)
                throw new ArgumentException("Number of columns in first matrix must equal number of rows in second matrix");

            Matrix result = new Matrix(m1.Rows, m2.Columns);

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m2.Columns; j++)
                {
                    for (int k = 0; k < m1.Columns; k++)
                    {
                        result[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }

            return result;
        }

        public static bool operator ==(Matrix m1, Matrix m2)
        {
            if (m1.Rows != m2.Rows || m1.Columns != m2.Columns)
                return false;

            for (int i = 0; i < m1.Rows; i++)
            {
                for (int j = 0; j < m1.Columns; j++)
                {
                    if (m1[i, j] != m2[i, j])
                        return false;
                }
            }

            return true;
        }

        public static bool operator !=(Matrix m1, Matrix m2)
        {
            return !(m1 == m2);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Matrix))
                return false;

            return this == (Matrix)obj;
        }
    }
}
