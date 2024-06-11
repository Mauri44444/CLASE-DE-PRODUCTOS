namespace PRACTICA;

class Program
{
    static void Main(string[] args)
    {
        // Instanciar dos objetos de la clase Producto utilizando los constructores
            Producto producto1 = new Producto("salvita", "banana", 5.0, 100);
            Producto producto2 = new Producto("Rio Negro", "manzana", 3.0, 50);

        
        // Mostrar el nombre, precio y stock de cada producto
            Console.WriteLine($"Producto 1: Nombre: {producto1.Nombre}, Precio: {producto1.Precio}, Stock: {producto1.Stock}");

            Console.WriteLine($"Producto 2: Nombre: {producto2.Nombre}, Precio: {producto2.Precio}, Stock: {producto2.Stock}");
            
            
        // Solicitar al usuario que elija un producto para vender
            Console.WriteLine("¿Qué producto desea vender? (1 para Producto1, 2 para Producto2)");
            int opcion = int.Parse(Console.ReadLine());

        
        // Solicitar la cantidad a vender
            Console.WriteLine("¿Cuántas unidades desea vender?");
            int cantidad = int.Parse(Console.ReadLine());

        
        // Disminuir el stock del producto elegido
        
        {
           if (opcion == 1)
            {
                producto1.Vender(cantidad);
            }
            else if (opcion == 2)
            {
                producto2.Vender(cantidad);
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            } 
        }
        
            // Mostrar el estado final de cada producto
            Console.WriteLine($"Producto 1: Nombre: {producto1.Nombre}, Precio: {producto1.Precio}, Stock: {producto1.Stock}");
            
            Console.WriteLine($"Producto 2: Nombre: {producto2.Nombre}, Precio: {producto2.Precio}, Stock: {producto2.Stock}");
    }
}
