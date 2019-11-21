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
     public static class ProjectManager
    {
        
        public static void SaveToFile(Project project, string filename )
    {
        // Создаём экземпляр сериализатора
        JsonSerializer serializer = new JsonSerializer();
        //Открываем поток для записи в файл с указанием пути
        using (StreamWriter sw = new StreamWriter(filename))
        using (JsonWriter writer = new JsonTextWriter(sw))
        {
            //Вызываем сериализацию и передаем объект, который хотим сериализовать. Использую временно Note взаместо Project.
            serializer.Serialize(writer, project);
        }
    }
        
        public static Project LoadFromFile(string filename)
        {
            //Создаём переменную, в которую поместим результат десериализации
           //  Note note = null;
            Project tempdictionary = new Project();
            //Создаём экземпляр сериализатора
            JsonSerializer serializer = new JsonSerializer();
            //Открываем поток для чтения из файла с указанием пути
            using (StreamReader sr = new StreamReader(filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                //Вызываем десериализацию и явно преобразуем результат в целевой тип данных
              tempdictionary = serializer.Deserialize<Project>(reader);
            }
            return tempdictionary;
        }
    }
}
