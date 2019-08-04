namespace AcuCafe
{
    /*
     * Usind an Interface to manage all types of drinks instaed of Inheritance
     * 
     */
    public interface IDrink
    {
        string Description { get; }

        double Cost();
        void Prepare();
    }
}