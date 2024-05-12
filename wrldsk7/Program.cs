using System;

// Обобщенный класс GenericArray
public class GenericArray<T>
{
    private T[] array; // Массив элементов типа T
    private int length; // Длина массива

    // Конструктор класса, инициализирующий массив заданного размера
    public GenericArray(int size)
    {
        array = new T[size];
        length = size;
    }

    // Метод для добавления элемента в массив по указанному индексу
    public void Adding_data(int index, T element)
    {
        if (index >= 0 && index < length)
        {
            array[index] = element;
        }
        else
        {
            Console.WriteLine("Недопустимый индекс.");
        }
    }

    // Метод для удаления элемента из массива по указанному индексу
    public void Remove_items(int index)
    {
        if (index >= 0 && index < length)
        {
            array[index] = default(T);
        }
        else
        {
            Console.WriteLine("Недопустимый индекс.");
        }
    }

    // Метод для получения элемента из массива по указанному индексу
    public T GetElement(int index)
    {
        if (index >= 0 && index < length)
        {
            return array[index];
        }
        Console.WriteLine("Недопустимый индекс.");
        return default(T);
    }

    // Метод для получения длины массива
    public int GetLength()
    {
        return length;
    }
}

class Program
{
    static void Main()
    {
        // Использование GenericArray с различными типами данных

        // Создание объекта GenericArray<int> для работы с целочисленным массивом
        GenericArray<int> intArray = new GenericArray<int>(3);
        intArray.Adding_data(0, 14);
        intArray.Adding_data(1, 21);
        intArray.Adding_data(2, 52);
        Console.WriteLine($"Длина целочисленного массива: {intArray.GetLength()}");
        Console.WriteLine($"Элемент масива с индексом 2 равен: {intArray.GetElement(2)}");

        // Создание объекта GenericArray<string> для работы со строковым массивом
        GenericArray<string> stringArray = new GenericArray<string>(2);
        stringArray.Adding_data(0, "Hello");
        stringArray.Adding_data(1, "World");
        Console.WriteLine($"Длина строкового массива: {stringArray.GetLength()}");
        Console.WriteLine($"Элемент масива с индексом 1 равен: {stringArray.GetElement(1)}");

        // Создание объекта GenericArray<double> для работы с массивом чисел с плавающей точкой
        GenericArray<double> doubleArray = new GenericArray<double>(4);
        doubleArray.Adding_data(0, 3.14);
        doubleArray.Adding_data(1, 1.618);
        doubleArray.Adding_data(2, 2.718);
        doubleArray.Adding_data(3, 2.72222);
        Console.WriteLine($"Длина массива чисел с плавающей точкой: {doubleArray.GetLength()}");
        Console.WriteLine($"Элемент масива с индексом 3 равен: {doubleArray.GetElement(3)}");
    }
}
