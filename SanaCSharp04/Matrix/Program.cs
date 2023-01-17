using System;
using System.ComponentModel.Design;
using System.Text;
using Matrix;

namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            var matrix = MatrixOperations.MatrixGeneration(5, 5, -5, 10);
            MatrixOperations.MatrixOutPut(matrix);
            //1 завдання
            Console.WriteLine($"\n1. Кількість додатних елементів: {MatrixOperations.GetAmmountOfPositiveNumbers(matrix)}");

            //2 завдання
            Console.WriteLine($"\n2. Mаксимальне із чисел, що зустрічається в заданій матриці більше одного разу: {MatrixOperations.GetMaxElemMoreThanOneTime(matrix)}");

            //3 завдання
            Console.WriteLine($"\n3. Kількість рядків, які не містять жодного нульового елемента: {MatrixOperations.GetAmmountOfNotContainedZeroForRows(matrix)}");

            //4 завдання
            Console.WriteLine($"\n4. Kількість стовпців, які містять хоча б один нульовий елемент: {MatrixOperations.GetAmmountOfContainedZeroForColumns(matrix)}");

            //5 завдання
            Console.WriteLine($"\n5. Hомер рядка, в якому знаходиться найдовша послідовність однакових елементів: {MatrixOperations.GetRowIndexWithLargestSeria(matrix)}");

            //6 завдання
            Console.WriteLine("\n6. Добуток елементів в тих рядках, які не містять від’ємних елементів:");
            MatrixOperations.MultiplicationOfRowsWithoutNegativeNumbers(matrix);

            //7 завдання
            Console.WriteLine($"\n7. Mаксимум серед сум елементів діагоналей, паралельних головній діагоналі матриці: {MatrixOperations.GetMaxAmongSumsOfDiagonalElementsParallelToMain(matrix)}");

            //8 завдання
            Console.WriteLine($"\n8. Cуму елементів в тих стовпцях, які не містять від’ємних елементів");
            MatrixOperations.SumOfColumnsWithoutNegativeNumbers(matrix);

            //9 завдання
            Console.WriteLine($"\n9. Mінімальний елемент серед сум модулів елементів діагоналей, паралельних побічній діагоналі матриці: {MatrixOperations.GetMinSumAmongSumsOfDiagonalElementsParallelToSide(matrix)}");

            //10 завдання
            Console.WriteLine($"\n10. Cума елементів в тих стовпцях, які  містять хоча б один від’ємний елемент:");
            MatrixOperations.SumOfColumnsWithNegativeNumbers(matrix);

            //11 завдання
            Console.WriteLine("\n11. Tранспонована матриця:");
            MatrixOperations.PrintTransportMatrix(matrix);
        }
    }
}
