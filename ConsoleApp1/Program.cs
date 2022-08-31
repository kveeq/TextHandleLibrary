// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Yields.MachineLearning.Class1.QuestionEvent = () => Console.ReadLine(); // передавать метод для возврата ответа к вопросу ассистента (return текст из распознанного текста)
Yields.MachineLearning.Class1.AnswerEvent = (mess) => Console.WriteLine(mess); // передавать метод для отображения ответа ассистента (голосовой ответ)
var handle = new Yields.MachineLearning.Class1(Console.ReadLine());
handle.Handling();
