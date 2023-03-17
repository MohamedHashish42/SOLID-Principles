namespace SOLID_Principles.LSP
{
    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Apple2 : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange2 : Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
