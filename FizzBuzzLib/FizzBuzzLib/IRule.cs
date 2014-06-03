namespace FizzBuzzLib
{
    public interface IRule
    {
        bool IsMatch(int number);
        string GetResult();
    }
}