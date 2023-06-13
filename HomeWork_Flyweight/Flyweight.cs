using Newtonsoft.Json;

namespace RefactoringGuru.DesignPatterns.Flyweight.Conceptual
{
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            this._sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(this._sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Приспособленец: Отображение общего {s} и уникальный {u} состояние.");
        }
    }
}
