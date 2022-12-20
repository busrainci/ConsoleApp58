// See https://aka.ms/new-console-template for more information


MyDictionary<string> dictionary = new MyDictionary<string>();
dictionary.Add("kelime1");
dictionary.Add("kelime2");
dictionary.Add("kelime3");
dictionary.Add("kelime4");
dictionary.Add("kelime5");


class MyDictionary<T>
{
    T[] array;
    T[] tempArray;
    public MyDictionary()
    {
        array = new T[0];

    }
    public void Add(T item)
    {
        tempArray = array;
        array = new T[array.Length + 1];

        for (int i = 0; i < tempArray.Length; i++)
        {
            tempArray[i] = array[i];
        }
        array[array.Length - 1] = item;
    }

}

