/*
 * Created by SharpDevelop.
 * User: julie
 * Date: 16/11/2022
 * Time: 10:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace TP_Final
{
	/// <summary>
	/// Description of empresa.
	/// </summary>
	public class empresa
	{
			
	//atributos
	private string nombre;//ju
	private ArrayList listaclientes;
	private ArrayList listatecnico;
	private ArrayList preciocombos;
	private ArrayList clientesconcombop;
	private DateTime fechalimitePromo;
	private int cupoPromo;

	
	
	// Constructor
	public empresa (string n)
	{
		this.nombre=n;
		listaclientes = new ArrayList();
		listatecnico= new ArrayList();
		clientesconcombop=new ArrayList();
		preciocombos=new ArrayList(){2000.0, 3000.0, 4000.0,5000.0};
		fechalimitePromo=new DateTime(2022, 12,01);
		cupoPromo=2;
	}
	
	public string Nombre{
		get{return this.nombre;}
		//set{this.nombre=value;}
	}
	
//	public ArrayList ListaTecnicos{
//		get{return this.listatecnico;}
//	}
	public DateTime FechaLimitePromo{
		get{return this.fechalimitePromo;}
	}
	public int CupoPromocion{
		get{return this.cupoPromo;}
	}
	
//	public ArrayList ListaClientes{
//		get{return this.listaclientes;}
//	}
//	
	public ArrayList PrecioCombos{
		get{return this.preciocombos;}
	}
	
	// Metodos clientes
	
	public void agregarcliente(cliente c1)
	{listaclientes.Add(c1);    
	}
	public void agregarclientecp(cliente c1)
	{clientesconcombop.Add(c1);    
	}
	
	public void eliminarcliente(cliente c)
	{
			listaclientes.Remove(c);
	}
		
	public int cantidadcliente()	
	{ 
		return listaclientes.Count;
		
	}
	
		
	public int cantidadclienteconcp()	
	{ 
		return clientesconcombop.Count;
		
	}
	public void exixtecliente(cliente c3)
	{ listaclientes.Contains(c3);
	}
	
	
	public cliente vercliente(int e){
		return (cliente) listaclientes[e];
	}


	public ArrayList todoslosclientes()
	{
		return listaclientes;
	}

	//metodo de tecnicos
	
	public void agregartecnico(tecnico unTec)
	{
		listatecnico.Add(unTec);
	}
	
	
	public void eliminartecnico(tecnico unTec)
	{
		listatecnico.Remove(unTec);
	}
		
	public int cantidadtecnico()	
	{
		return listatecnico.Count;
	}
	
	
	public bool exixtetecnico(tecnico unTec)
	{
		return listatecnico.Contains(unTec);
	}
	
	
	public tecnico Vertecnico(int i)
	{
		return (tecnico)listatecnico[i];
	}

	public ArrayList todoslostecnicos()
	{
		return listatecnico;
	}
 

	public void VerificarNumeroCliente(cliente clie, int e){
		int contador=e;
		bool exs=false;
	
		try{
			if(!exs){
				foreach(tecnico t in listatecnico){
					if (t.Numtec==e){
						exs=true;
					}
					else{
						continue;
						
					}

				}
				foreach(cliente c in listaclientes){
					if (c.Num_cliente==e){
						exs=true;
					}
			else{
						continue;
						
					}		

				}
				clie.Num_cliente=contador;
			}
			
			
			if(exs==true){
				throw new Exception();
				
			}

			Console.ReadKey(true);
		}
		
		catch(Exception){
			//Console.WriteLine("se repite");	
			VerificarNumeroCliente(clie, e+1);
		   
		}
		}

	
	public void VerificarNumeroTecnico(tecnico te, int e){
		int contador=e;
		bool exs=false;
	
		try{
			if(!exs){
				foreach(cliente c in listaclientes){
					if (c.Num_cliente==e){
						exs=true;
					}
//					else{
//						te.Numtec=contador;
//						
//					}

				}
				foreach(tecnico tecsn in listatecnico){
					if(tecsn.Numtec==e){
						exs=true;
					}
//						else{
//							te.Numtec=contador;
//						}
					}
				te.Numtec=contador;
				}
			
			
			
			if(exs==true){
				throw new Exception();
				
			}

			Console.ReadKey(true);
		}
		
		catch(Exception){
//			Console.WriteLine("se repite");	
			VerificarNumeroTecnico(te, e+1);
		   
		}
		}
	}
		
	}

