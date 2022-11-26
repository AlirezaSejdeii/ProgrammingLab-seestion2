using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

Matrix<double> a = DenseMatrix.OfArray(new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
Matrix<double> b = DenseMatrix.OfArray(new double[,] { { 1 }, { 2 }, { 3 } });
Matrix<double> result = a * b;

Console.WriteLine(result);