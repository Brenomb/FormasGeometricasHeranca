namespace Figuras
{
    public class Programa
    {
        public class Figura
        {
            public float area {get ; set;}
            public float perimetro {get; set;}
            protected String nome = "";

            public String Nome
            {
                get
                {
                    return nome;
                }
                
            }
        }

        public class Retangulo : Figura
        {
            public float ladoA { get; }
            public float ladoB { get; }

            public Retangulo(float LadoA, float LadoB )
            {
                nome = "Retangulo";
                this.ladoA = LadoA;
                this.ladoB = LadoB;
                area = ladoA * ladoB;
                perimetro = 2*(ladoA + ladoB);
            }

            public float Diagonal
            {
                get
                {
                    return (float)Math.Sqrt(ladoA * ladoA + ladoB * ladoB);
                }
                
                
            }
        }

        public class Circulo : Figura
        {
            private float raio {get;}

            public Circulo(float Raio)
            {
                nome = "Circulo";
                this.raio = Raio;
                area = (float)Math.PI * (float)Math.Sqrt(raio);
                perimetro = (float)Math.PI * 2 * raio;
            }

        }

        public class Quadrado : Retangulo
        {

            public Quadrado(float lado) : base(lado, lado)
            {
                nome = "Quadrado";
            }
        }

        public class TrianguloEquilatero : Figura
        {
            public float lado;
            public float altura;
            
            public TrianguloEquilatero(float lado)
            {
                nome = "Triângulo Equilátero";
                this.lado = lado;
                altura = lado * (float)Math.Sqrt(3)/2;
                perimetro = 3*lado;
                area = lado * altura /2;
            }
        }

        public class TrianguloRetangulo
        {
            private Retangulo r;
            
            public String Nome
            {
                get
                {
                    return "Triangulo Retângulo";
                }
            }

            public float area
            {
                get
                {
                    return r.area/2;
                }
            }

            public float perimetro
            {
                get
                {
                    return r.ladoA + r.ladoB + r.Diagonal;
                }
            }

            public float Hipotenusa
            {
                get
                {
                    return r.Diagonal;
                }
            }
 
            public TrianguloRetangulo(float catetoA, float catetoB)
            {
                r = new Retangulo(catetoA, catetoB);
            }
        }

        public class HexagonoRegular
        {
            private TrianguloEquilatero teD;

            public String Nome
            {
                get
                {
                    return "Hexagono Regular";
                }
            }

        //(3√3 s2)/ 2     3
            public float area
            {
                get
                {
                    return (float)teD.area * 6 ;
                }
            }
                
            public HexagonoRegular(float lado)
            {
                teD = new TrianguloEquilatero(lado);
            }

            public float perimetro
            {
                get
                {
                    return teD.lado*6;
                }
            }
        }


        public static int Main(String [] args)
        {
            Retangulo r = new Retangulo(3, 4);
            Circulo c = new Circulo(1);
            Quadrado q = new Quadrado(10);
            TrianguloEquilatero te = new TrianguloEquilatero(10);
            TrianguloRetangulo tr = new TrianguloRetangulo(3, 4);
            HexagonoRegular hr = new HexagonoRegular(10);

            //Retangulo
            Console.WriteLine("\nRetangulo: ");
            Console.WriteLine(  "Nome: " + r.Nome +
                                " Area: " + r.area +
                                " Perímetro: " + r.perimetro+
                                " Diagonal: " + r.Diagonal);
            
            //Circulo
            Console.WriteLine("\nCirculo: ");
            Console.WriteLine(  "Nome: " + c.Nome + 
                                " Area: " + c.area + 
                                " Perímetro: " + c.perimetro);
                
            //Quadrado
            Console.WriteLine("\nQuadrado: ");
            Console.WriteLine(  "Nome: " + q.Nome + 
                                " Area: " + q.area + 
                                " Perímetro: " + q.perimetro+
                                " Diagonal: "+ q.Diagonal);

            //Triangulo Equilatero
            Console.WriteLine("\nTriangulo Equilatero: ");
            Console.WriteLine(  "Nome: " + te.Nome + 
                                " Area: " + te.area + 
                                " Perímetro: " + te.perimetro+
                                " Altura: "+ te.altura);

            //Triangulo Retangulo     
            Console.WriteLine("\nTriangulo Retangulo: ");
            Console.WriteLine(  "Nome: " + tr.Nome + 
                                " Area: " + tr.area + 
                                " Perímetro: " + tr.perimetro+
                                " Altura: "+ tr.Hipotenusa);

            //Hexagono Regular
            Console.WriteLine("\nHexagono Regular");
            Console.WriteLine(  "Nome: " + hr.Nome + 
                                " Area: " + hr.area + 
                                " Perímetro: " + hr.perimetro);
            
            return 0;
        }
    }
}