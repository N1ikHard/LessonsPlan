using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LessonsPlan
{
    public partial class FormShedule : Form
    {
        string filename = "Lessons.txt";                                            //Путь до файла
        public FormShedule()                        
        {
            InitializeComponent();
            LoadGrid();
        }
        private void LoadGrid()                                                     //Метод для загрузки данных в DataGridView
        {
            GridWeek.Rows.Clear();                                                  //Очищаем первую строку
            using (StreamReader reader = new StreamReader(filename, Encoding.UTF8))//Создаем поток для считывания данных
            {
                int RowIndex = 0;                                                   //Для увеличения строк и их заполнения
                while (!reader.EndOfStream)                                         //вводим данное поле , дальше пока поток
                {                                                                   //считывает данные добавляем строку для 
                    GridWeek.Rows.Add();                                            //ее последующего заполнения
                    foreach (DataGridViewColumn col in GridWeek.Columns)            //Перебираем значения в колоннах
                    {
                        string item = reader.ReadLine();                            //Считываем значение строки в файле ч\з поток
                        GridWeek[col.Index, RowIndex].Value = item;                 //Присваиваем значения через индексы :                     }                                                           //и полю текущей строки
                    };                                                              //перебираемых колон и текущей строки
                    RowIndex++;                                                     //присваиваем значение  
                                                                                    //После конца цикла столбцов , увеличиваем 
                }                                                                   //Индекс строк
            }
        }
        private void SaveGrid()                                                     //Метод для сохранения результатов
        {                                                                           //Объявляем поток
            using (StreamWriter writer = new StreamWriter(filename, false, Encoding.UTF8))
            {
                foreach (DataGridViewRow row in GridWeek.Rows)                      //Перебираем значения строк
                {
                    foreach (DataGridViewColumn col in GridWeek.Columns)            //Перебираем значения колонн
                    {                                                               
                        string item;                                                //Переменная для записи содержимого ячейки
                        if (GridWeek[col.Index, row.Index].Value == null)           //Если ячейка пустая ,то запись в переменную
                            item = "";
                        else
                            item = GridWeek[col.Index, row.Index].Value.ToString(); ;//Присвоение значения , если ячейка не пустая
                        writer.WriteLine(item);                                      //Запись результата в файл
                    }
                }
            };
        }

        private void GridWeek_CellEndEdit(object sender, DataGridViewCellEventArgs e)//Событие при изменении ячейки
        {
            SaveGrid();
        }
    }
}
