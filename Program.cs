using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {
            //A
            int CantProductos;
            int[,] CProductos;
            int IdProducto;
            int IdStock;
            bool flag;
            bool flag2;
            bool flag3;
            bool flag4;
            bool flag5;

            do
            {
                Console.WriteLine("Ingrese cantidad de productos: ");
                CantProductos = Convert.ToInt32(Console.ReadLine());
                if (CantProductos <= 0)
                {
                    Console.WriteLine("Ingrese un valor mayor o igual a 0");
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            } while (!flag);

            CProductos = new int[CantProductos, 2];

            for (int i = 0; i < CantProductos; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese el Id del producto: ");
                    IdProducto = Convert.ToInt32(Console.ReadLine());
                    if (IdProducto < 0)
                    {
                        Console.WriteLine("Ingrese un valor igual o menor a 0");
                        flag2 = false;
                    }
                    else
                    {
                        flag2 = true;
                    }

                } while (!flag2);
                do
                {
                    Console.WriteLine("Ingrese el stock: ");
                    IdStock = Convert.ToInt32(Console.ReadLine());
                    if (IdStock <= 0)
                    {
                        Console.WriteLine("Ingrese un valor igual o menor a 0");
                        flag3 = false;
                    }
                    else
                    {
                        flag3 = true;
                    }

                } while (!flag3);

                CProductos[i, 0] = IdProducto;
                CProductos[i, 1] = IdStock;
            }

            //B
            int Pedido;
            int Entrega;
            int idpedido;

            Console.WriteLine("Ingrese el id producto: ");
            idpedido = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Ingrese la cantidad de pedidos:");
                Pedido = Convert.ToInt32(Console.ReadLine());
                if (Pedido < 0)
                {
                    Console.WriteLine("Ingrese un valor menor a 0");
                    flag4 = false;
                }
                else
                {
                    flag4 = true;
                }
            } while (!flag4);

            do
            {
                Console.WriteLine("Ingrese la cantidad de entregas:");
                Entrega = Convert.ToInt32(Console.ReadLine());
                if (Entrega < 0)
                {
                    Console.WriteLine("No se puede ingresar un valor menor a 0");
                    flag5 = false;
                }
                else
                {
                    flag5 = true;
                }
            } while (!flag5);

            //C
            for (int i = 0; i < CProductos.GetLength(0); i++)
            {

                if (CProductos[i, 0] == Convert.ToInt32(idpedido))
                {
                    
                    CProductos[i, 1] = CProductos[i, 1] - Pedido;
                    CProductos[i, 1] = CProductos[i, 1] + Entrega;
                    
                }
            }

            for (int i = 0; i < CantProductos; i++)
            {
                Console.WriteLine("El producto ",CProductos[i, 0],"tiene", CProductos[i, 1] ,"unidades");
            }
            
        }
    }
}

