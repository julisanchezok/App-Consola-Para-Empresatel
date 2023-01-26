/*
 * Created by SharpDevelop.
 * User: julie
 * Date: 16/11/2022
 * Time: 10:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace TP_Final
{
	/// <summary>
	/// Description of tecnico.
	/// </summary>
	public class tecnico
	{
		
		//atributos
 
	private string nombre;
	private string apellido;
	private int numtec; 
	private static int contador=0;
	private int area;
	
	//Costructor
	public tecnico (string nombre, string apellido, int area)
	{
		this.nombre = nombre;
		this.apellido = apellido;
		this.area= area;
		contador++;
		numtec=contador;
		
	}
	
	public string Nombre 
	{
		set{nombre= value;}
		get{return nombre;}
	}
	public string Apellido 
	{
		set{this.apellido = value;} //ju
		get{return this.apellido;}
	}	
	public int Area 
	{
		set{area= value;}
		get{return area;}
	}
	public int Numtec
	{set{this.numtec=value;}
		get{return numtec;}
			
	}

	//metodos
	public void ImprimirTecnico(){
		Console.WriteLine(numtec +" "+ nombre +" "+apellido+" zona: "+area);
	}
	}
}
