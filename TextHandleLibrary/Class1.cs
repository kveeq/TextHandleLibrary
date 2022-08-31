using System;
using Yields.MachineLearning;

namespace TextHandleLibrary
{
    public class Class1
    {
        public static void Main()
        {
            Yields.MachineLearning.Class1.QuestionEvent = () => Console.ReadLine(); // передавать метод для возврата ответа к вопросу ассистента (return текст из распознанного текста)
            Yields.MachineLearning.Class1.AnswerEvent = (mess) => Console.WriteLine(mess); // передавать метод для отображения ответа ассистента (голосовой ответ)
            var handle = new Yields.MachineLearning.Class1(Console.ReadLine());
            handle.Handling();
        }
    }
}