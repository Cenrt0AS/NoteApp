using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс Сериализации, с помощью которого выполняется загрузка/выгрузка информации в формате JSON.
    /// </summary>
    class Serialize
    {
        public static void SaveToFile(<type> data, string filename)
        {
            ////Создаём экземпляр сериализатора
            //JsonSerializer serializer = new JsonSerializer();
            ////Открываем поток для записи в файл с указанием пути
            //using (StreamWriter sw = new StreamWriter(@"c:\json.txt"))
            //using (JsonWriter writer = new JsonTextWriter(sw))
            //{
            //    //Вызываем сериализацию и передаем объект, который хотим сериализовать
            //    serializer.Serialize(writer, note);
            //}

            
        //public static <type> LoadFromFile(string filename)
        //{
        //        //Создаём переменную, в которую поместим результат десериализации
        //        Note note = null;
        //        //Создаём экземпляр сериализатора
        //        JsonSerializer serializer = new JsonSerializer();
        //        //Открываем поток для чтения из файла с указанием пути
        //        using (StreamReader sr = new StreamReader(@"c:\json.txt"))
        //        using (JsonReader reader = new JsonTextReader(sr))
        //        {
        //            //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
        //            note = (Note)serializer.Deserialize<Note>(reader);
        //        }
            }
    }
}
