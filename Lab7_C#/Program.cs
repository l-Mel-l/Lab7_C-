public class Array<T>{
    private List<T> list;

    public Array(int size){
        list = new List<T>(size);
    }

    //метод для получения элемента из списка по индексу
    public T GetItem(int index){
        if (index < 0 || index >= list.Count) throw new IndexOutOfRangeException("Неправильный индекс");
        return list[index];
        }

    //метод для добавления значения в список
        public void SetItem(T value){
            list.Add(value);
        }

    //метод для удаления значения из список
        public void RemoveItem(int index){
            if (index < 0 || index >= list.Count) throw new IndexOutOfRangeException("Неправильный индекс");
            list = list.Where((source, i) => i != index).ToList();
        }

    //метод для возвращения длинны списка
    public int Size(){
        return list.Count;
    }

    //метод для вывода занчений списка
    public void PrintAllItems(string name){
        Console.WriteLine($"{name} список ({Size()} элементов):"); ;
        for (int i = 0; i < list.Count; i++){
            Console.Write(list[i] + (i < list.Count - 1 ? "; " : "\n"));
        }
        Console.WriteLine("-------------------------------");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //создаём целочисленный список
        Array<int> intArray = new Array<int>(5);
        for (int i = 0; i < 4; i++)
        {
            intArray.SetItem(i);
        }

        //создаём строковый список
        Array<string> strArray = new Array<string>(5);
        strArray.SetItem("Сила");
        strArray.SetItem("Ловкость");
        strArray.SetItem("Скорость");
        strArray.SetItem("Свет");

        //создаём список чисел с плавающей точкой
         Array<double> doubleArray = new Array<double>(5);
        doubleArray.SetItem(1.2);
        doubleArray.SetItem(2.7);
        doubleArray.SetItem(5.2);
        doubleArray.SetItem(12.747365);

        //выводим изначальное состояние списков и их длинну
        intArray.PrintAllItems("Целочисленный");
        strArray.PrintAllItems("Строковый");
        doubleArray.PrintAllItems("Чисел с плавающей точкой");

        //добавляем значения в список
        intArray.SetItem(42); 
        strArray.SetItem("Тьма");
        doubleArray.SetItem(-1.123);

        // Выводим состояние списков после изменений
        Console.WriteLine("Добавляем некоторые значения в список \nНовые Списки:\n-------------------------------");
        intArray.PrintAllItems("Целочисленный");
        strArray.PrintAllItems("Строковый");
        doubleArray.PrintAllItems("Чисел с плавающей точкой");

        //удаляем некоторые значения из списков
        intArray.RemoveItem(0);
        strArray.RemoveItem(0);
        doubleArray.RemoveItem(0);


        // Выводим состояние списков после изменений
        Console.WriteLine("Удаляем некоторые значения в списках \nНовые Списки:\n-------------------------------");
        intArray.PrintAllItems("Целочисленный");
        strArray.PrintAllItems("Строковый");
        doubleArray.PrintAllItems("Чисел с плавающей точкой");
    }
}