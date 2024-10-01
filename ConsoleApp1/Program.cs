using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_fot_DB;
using ClassLibrary_fot_DB.Data_Layer_folder;
using ClassLibrary_fot_DB.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// создаем несколько об-ов 
            //var db = new EnglishDbContext();

            //////1

            //Category category = new Category();
            //category.Title = "Живое";

            //Type_ type = new Type_();
            //type.Title = "Простой";

            //Question question = new Question();
            //question.Title = "Кто изображен на этой картинке?";
            //question.Type = type;
            //question.Category = category;

            //Answer_mas answer_mas = new Answer_mas();
            //answer_mas.Question = question;

            //Answer answer = new Answer();
            //answer.Title = "Cat";
            //answer.IsRight = true;
            //answer.Answer_mas = answer_mas;

            //db.Categories.Add(category);
            //db.Types.Add(type);
            //db.Questions.Add(question);
            //db.Answer_mas.Add(answer_mas);
            //db.Answers.Add(answer);

            //db.SaveChanges();

            //1 Добавление категории
            //Data_Layer_model.Category.Insert("Неживое");

            //2 Добавление типа
            //Data_Layer_model.Type_.Insert("Сложный");

            //3 Добавление вопросов
            //Data_Layer_model.Question.Insert("Что изображено на этой картинке?", 2, 1);

            //Data_Layer_model.Question.Insert("В какое время суток происходит действие?", 2, 1);
            //Data_Layer_model.Question.Insert("Какой цвет пробладает на этой картинке?", 2, 1);

            //Data_Layer_model.Question.Insert("Что сейчас делает животное?", 1, 1);
            //Data_Layer_model.Question.Insert("Какое действие происходит на картинке?", 1, 1);

            //Data_Layer_model.Question.Insert("Сколько животных вы видите на картинке?", 1, 2);
            //Data_Layer_model.Question.Insert("Сколько предметов вы видите на картинке?", 2, 2);

            //Data_Layer_model.Question.Insert("Где находится животное?", 1, 2);
            //Data_Layer_model.Question.Insert("Где происходит действие?", 2, 2);

            //4 Добавление массивов ответов
            //Data_Layer_model.Answer_mas.Insert(2);
            //Data_Layer_model.Answer_mas.Insert(3);
            //Data_Layer_model.Answer_mas.Insert(4);
            //Data_Layer_model.Answer_mas.Insert(5);
            //Data_Layer_model.Answer_mas.Insert(6);
            //Data_Layer_model.Answer_mas.Insert(7);
            //Data_Layer_model.Answer_mas.Insert(8);
            //Data_Layer_model.Answer_mas.Insert(9);
            //Data_Layer_model.Answer_mas.Insert(10);

            //5 Добавление ответов

            Data_Layer_model.Answer.Insert("dog", false, 1);
            Data_Layer_model.Answer.Insert("bird", false, 1);
                                               
            Data_Layer_model.Answer.Insert("pen", false, 2);
            Data_Layer_model.Answer.Insert("key", true, 2);
            Data_Layer_model.Answer.Insert("table", false, 2);
                                               
            Data_Layer_model.Answer.Insert("evening", false, 3);
            Data_Layer_model.Answer.Insert("night", false, 3);
            Data_Layer_model.Answer.Insert("day", true, 3);
                                               
            Data_Layer_model.Answer.Insert("red", true, 4);
            Data_Layer_model.Answer.Insert("green", false, 4);
            Data_Layer_model.Answer.Insert("black", false, 4);
                                               
            Data_Layer_model.Answer.Insert("sleeping", false, 5);
            Data_Layer_model.Answer.Insert("siting", true, 5);
            Data_Layer_model.Answer.Insert("standing", false, 5);
                                               
            Data_Layer_model.Answer.Insert("flight", true, 6);
            Data_Layer_model.Answer.Insert("growling", false, 6);
            Data_Layer_model.Answer.Insert("sleeo", false, 6);
                                               
            Data_Layer_model.Answer.Insert("two", false, 7);
            Data_Layer_model.Answer.Insert("one", true, 7);
            Data_Layer_model.Answer.Insert("three", false, 7);
                                               
            Data_Layer_model.Answer.Insert("one", true, 8);
            Data_Layer_model.Answer.Insert("two", false, 8);
            Data_Layer_model.Answer.Insert("three", false, 8);
                                              
            Data_Layer_model.Answer.Insert("sky", false, 9);
            Data_Layer_model.Answer.Insert("ground", false, 9);
            Data_Layer_model.Answer.Insert("sea", true, 9);
                                               
            Data_Layer_model.Answer.Insert("sky", true, 10);
            Data_Layer_model.Answer.Insert("ground", false, 10);
            Data_Layer_model.Answer.Insert("sea", false, 10);

            Console.WriteLine("Ok!");
        }
    }
}
