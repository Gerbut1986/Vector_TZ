namespace Sortable_Shapes
{
    public abstract class Shape : System.IComparable<Shape>
    {
        protected double area = 0;

        public int CompareTo(Shape other) => this.area.CompareTo(other.area);
    }
}
