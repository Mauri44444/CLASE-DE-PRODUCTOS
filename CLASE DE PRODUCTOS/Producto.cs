namespace PRACTICA;

class Producto
    {
        // Atributos privados
        private string codigo;
        private string nombre;
        private double precio;
        private int stock;

        // Constructor por defecto
        public Producto()
        {
            codigo = "";
            nombre = "";
            precio = 0.0;
            stock = 0;
        }
        
        // Constructor con todos los parámetros
        public Producto(string codigo, string nombre, double precio, int stock)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio; // Usamos el setter para aplicar la restricción
            this.stock = stock;   // Usamos el setter para aplicar la restricción
        }

        // Métodos de acceso (get)
        public string Codigo
        {
            get { return codigo; }
        }

        public string Nombre
        {
            get { return nombre; }
        }
        
        public double Precio
        {
            get { return precio; }
        }

        public int Stock
        {
            get { return stock; }
        }

        //Metodos de acceso (set)

        public void SetCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetPrecio(double precio)
        {
            if (precio < 0.0)
            {
                Console.WriteLine("El precio no puede ser menor a 0");
            }
            else
            {
                this.precio = precio;
            }
        }

        public void SetStock(int stock)
        {
            if (stock < 0)
            {
                Console.WriteLine("El stock no puede ser menor que 0");
            }
            else
            {
                this.stock = stock;
            }
        }
        
        // Método para vender producto
        public void Vender(int cantidad)
        {
            if (cantidad <= stock)
            {
                stock -= cantidad;
                Console.WriteLine($"Se han vendido {cantidad} unidades de {nombre}.");
            }
            else
            {
                Console.WriteLine("No hay suficiente stock para vender.");
            }
        }
    }

    
