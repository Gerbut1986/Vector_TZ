namespace Sortable_Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double triangleBase, double height) => this.area = (triangleBase * height) / 2;
    }
}
