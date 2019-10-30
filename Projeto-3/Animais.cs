using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe8
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            Console.Write("O animal é Mamíferos?? S/N => ");
            resposta = Console.ReadLine();
            if (resposta.ToUpper() == "S")
            {
                Console.Write("O animal é Quadrupede? S/N => ");
                resposta = Console.ReadLine();
                if (resposta.ToUpper() == "S")
                {
                    Console.Write("O animal é Carnivoro? S/N => ");
                    resposta = Console.ReadLine();
                    if (resposta.ToUpper() == "S")
                    {
                        Console.Write("O animal é um LEÂO !!!");
                    }
                    else
                    {
                        Console.Write("O animal é Herbívoro? S/N => ");
                        resposta = Console.ReadLine();
                        if (resposta.ToUpper() == "S")
                        {
                            Console.Write("O animal é um Cavalo !!!");
                        }
                        else
                        {
                            Console.Write("Animal Inexistente");
                        }

                    }
                }
                else
                {
                    Console.Write("O animal é Bípedes?? S/N => ");
                    resposta = Console.ReadLine();
                    if (resposta.ToUpper() == "S")
                    {
                        Console.Write("O animal é Onívoros? S/N => ");
                        resposta = Console.ReadLine();
                        if (resposta.ToUpper() == "S")
                        {
                            Console.Write("É um Homem");
                        }
                        else
                        {
                            Console.Write("O animal é Frutívoro?? S/N => ");
                            resposta = Console.ReadLine();
                            if (resposta.ToUpper() == "S")
                            {
                                Console.Write("O animal é um macaco !!!");
                            }
                            else
                            {
                                Console.Write("Animal Inexistente");
                            }
                        }
                    }
                    else
                    {
                        Console.Write("O animal é Voador?? S/N => ");
                        resposta = Console.ReadLine();
                        if (resposta.ToUpper() == "S")
                        {
                            Console.Write("O animal é um Morcego !!!");
                        }
                        else
                        {
                            Console.Write("O animal é Aquático !!!");
                            resposta = Console.ReadLine();
                            if (resposta.ToUpper() == "S")
                            {
                                Console.Write("O animal é uma Baleia");
                            }
                            else
                            {
                                Console.Write("Animal Inexistente");
                            }

                        }
                    }
                }





            }
            else
            {
                Console.Write("O animal é uma Ave?? S/N => ");
                resposta = Console.ReadLine();
                if (resposta.ToUpper() == "S")
                {
                    Console.Write("O animal é Não-Voador?? S/N =>");
                    resposta = Console.ReadLine();
                    if (resposta.ToUpper() == "S")
                    {
                        Console.Write("O animal é Tropical?? S/N =>");
                        resposta = Console.ReadLine();
                        if (resposta.ToUpper() == "S")
                        {
                            Console.Write("O animal é um Avestruz !!!");
                        }
                        else
                        {
                            Console.Write("O animal é Polar?? S/N");
                            resposta = Console.ReadLine();
                            if (resposta.ToUpper() == "S")
                            {
                                Console.Write("O animal um Pinguim !!!");
                            }
                            else
                            {
                                Console.Write("Animal Inexistente");
                            }
                        }
                    }
                    else
                    {
                        Console.Write("O animal é Nadador?? S/N");
                        resposta = Console.ReadLine();
                        if (resposta.ToUpper() == "S")
                        {
                            Console.Write("O animal é um Pato !!!");
                        }
                        else
                        {
                            Console.Write("O animal de Rapina?? S/N");
                            resposta = Console.ReadLine();
                            if (resposta.ToUpper() == "S")
                            {
                                Console.Write("O animal é uma Águia !!!");
                            }
                            else
                            {
                                Console.Write("Animal Inexistente");
                            }
                        }
                    }



                }
                else
                {
                    Console.Write("O animal é Réptil?? S/N =>");
                    resposta = Console.ReadLine();
                    if (resposta.ToUpper() == "S")
                    {
                        Console.Write("O animal tem Casco?? S/N =>");
                        resposta = Console.ReadLine();
                        if (resposta.ToUpper() == "S")
                        {
                            Console.Write("O animal é uma Tartaruga !!!");
                        }
                        else
                        {
                            Console.Write("O animal é Carnívoro?? S/N =>");
                            resposta = Console.ReadLine();
                            if (resposta.ToUpper() == "S")
                            {
                                Console.Write("O animal é Crocodilo !!!");
                            }
                            else
                            {
                                Console.Write("O animal é Sem Patas?? S/N =>");
                                resposta = Console.ReadLine();
                                if (resposta.ToUpper() == "S")
                                {
                                    Console.Write("O animal é uma Cobra !!!");
                                }
                                else
                                {
                                    Console.Write("Animal Inexistente !!!");
                                }
                            }
                        }

                    }
                    else
                    {
                        Console.Write("Então é o BIDU !!!");
                    }

                }


            }

            Console.ReadKey();

        }
    }
}
