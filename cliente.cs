/*
 * Created by SharpDevelop.
 * User: julie
 * Date: 16/11/2022
 * Time: 10:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
namespace TP_Final
{
	/// <summary>
	/// Description of cliente.
	/// </summary>
	public class cliente
	{
	private string nombre;
	private string apellido;
	private int DNI;
	private int num_cliente;
	private DateTime fecha;
	private string combovigente; 
	private double preciocombo;
	private static int contador=0;
	private int minconsumido;
	private string tec;
	private int zona;
	private bool comboplus;
	
	
	public cliente (string nombre, string apellido, int DNI, DateTime fecha, int minconsumido, string te, int z, bool cp, string combovi, double prec) {
		this.nombre = nombre;
		this.apellido = apellido;
		this.DNI = DNI;
		this.fecha = fecha;
		this.minconsumido = minconsumido;
		this.tec=te;
		this.zona=z;
		this.comboplus=cp;
		this.combovigente=combovi;
		this.preciocombo=prec;
		contador++;
		num_cliente=contador;
	}

	public cliente (string nombre, string apellido, int DNI, DateTime fecha, int minconsumido, string te, int z, string combovi, double prec) {
		this.nombre = nombre;
		this.apellido = apellido;
		this.DNI = DNI;
		this.fecha = fecha;
		this.minconsumido = minconsumido;
		this.tec=te;
		this.zona=z;
		
		this.combovigente=combovi;
		this.preciocombo=prec;
		contador++;
		num_cliente=contador;
	}
	public string Nombre
	{
		set{nombre = value;}
		get{return nombre;}
	}
	public string Apellido
	{
		set{apellido = value;}
		get{return apellido;}
	}
	public int dni
	{
		set{DNI = value;}
		get{return DNI;}
	}	

	public int Num_cliente
	{
		set{this.num_cliente = value;}
		get{return num_cliente;}
	}
	public DateTime Fecha
	{
		set{fecha = value;}
		get{return fecha;}
	}
	public string Combovigente
	{
		set{this.combovigente = value;}
		get{return this.combovigente;}
	}
	
	public string Tecnico{
		get{return this.tec;}
		set{this.tec=value;}
	}
	public int Minconsumido
	{
		set{minconsumido = value;}
		get{return minconsumido;}
	}
	
	public int Zona{
		get{return this.zona;}
		set{this.zona=value;}
	}
	public bool ComboPlus{
		get{return this.comboplus;}
		set{this.comboplus=value;}
	}
	
	public double PrecioCombo{
		get{ return this.preciocombo;}
	}
	
	public void ImprimirCliente(){
		string sino="";
		if(comboplus==true){
			sino="si";
		}
		else{
			sino="no";
		}
		Console.WriteLine("Numero de cliente: {0} \n Nombre y apellido: {1} {2} \n Dni: {3} \n Fecha de alta: {4} \n Combo: {5} \n Minutos consumidos: {6} \n Técnico asignado {7} \n Zona: {8} \n Combo Plus: {9} \n Precio: {10} ", num_cliente, nombre, apellido, DNI, fecha.ToShortDateString(), combovigente , minconsumido, tec,zona,sino, preciocombo);
		
	}
	}
}
