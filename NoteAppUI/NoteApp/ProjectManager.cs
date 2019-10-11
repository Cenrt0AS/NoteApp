using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace NoteApp
{
    /// <summary>
    /// Класс Сериализации, с помощью которого выполняется загрузка/выгрузка информации в формате JSON.
    /// </summary>
     public class ProjectManager
    { 
      
     public static void SaveToFile(Note note /*string filename*/)
    {
        // Создаём экземпляр сериализатора
        JsonSerializer serializer = new JsonSerializer();
        //Открываем поток для записи в файл с указанием пути
        using (StreamWriter sw = new StreamWriter(@"c:\json.txt"))
        using (JsonWriter writer = new JsonTextWriter(sw))
        {
            //Вызываем сериализацию и передаем объект, который хотим сериализовать. Использую временно Note взаместо Project.
            serializer.Serialize(writer, note);
        }
    }

    //    public static <Dictionary> LoadFromFile(string filename)
    //    {
    //            //Создаём переменную, в которую поместим результат десериализации
    //            Note note = null;
    //            //Создаём экземпляр сериализатора
    //            JsonSerializer serializer = new JsonSerializer();
    //            //Открываем поток для чтения из файла с указанием пути
    //            using (StreamReader sr = new StreamReader(@"c:\json.txt"))
    //            using (JsonReader reader = new JsonTextReader(sr))
    //            {
    //                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
    //                note = (Project)serializer.Deserialize<Note>(reader);
    //            }
    //}
}
}
