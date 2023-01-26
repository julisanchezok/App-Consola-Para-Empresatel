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
	class Program
	{
		public static void Main(string[] args)
		{
			
tecnico juan=new tecnico( "juan", "perez", 1);
tecnico rober=new tecnico("roberto", "lopez", 2);
tecnico raul=new tecnico( "raul", "gonzalez", 3);
empresa mov= new empresa("movistar");
mov.agregartecnico(juan);
mov.agregartecnico(rober);
mov.agregartecnico(raul);


            string bienvenida="Bienvendido a Movistar!";
            Console.WriteLine(bienvenida);

            string menu = "\n Ingrese:  " +
                "\n 1- Agregar Cliente y Asignarle un Técnico según el área donde vive el cliente, Ver si tiene Combo Plus" +
            "\n 2- Modificar la cantidad de minutos consumidos por un cliente dado" +
            "\n 3- Eliminar cliente de la empresa" +
            "\n 4- Dada un área determinada imprimir el nombre de los técnicos asignados a la misma" +
            "\n 5- Listado de clientes" +
            "\n 6- Agregar técnico" +
            "\n 7- Imprimir la facturación de cada cliente en base a su plan, aplicando la bonificación cuando corresponda" +
            "\n 8- Listado de técnicos" +
            "\n 9- Salir";
            origen:
            try{
            
            Console.WriteLine(menu);
            int opc = int.Parse(Console.ReadLine());
            
            while(opc<9){
            	switch(opc){
            		case 1:
            			AgregarCliente(mov);
            			Console.Clear();
            			Console.WriteLine(menu);
            			opc = int.Parse(Console.ReadLine());
            			
            			break;
            		case 2:
            			VerificarListaClientes(mov);
            			Console.WriteLine("Lista de clientes: \n");
            			ImprimirListaCliente(mov);
            			Console.WriteLine("ingrese el numero de cliente");
            			int nc= int.Parse(Console.ReadLine());
            			ModificarMinCons(mov,nc);
            			Console.Clear();
            			Console.WriteLine(menu);
            			opc = int.Parse(Console.ReadLine());
            			
            			break;
            		case 3:
            			VerificarListaClientes(mov);
            			Console.WriteLine("Lista de clientes: \n");
            			ImprimirListaCliente(mov);
            			Console.WriteLine("Ingrese el num de cliente a eliminar");
            		
            			
            			int numcl= int.Parse(Console.ReadLine());
            			EliminarCliente(mov,numcl);
            			Console.Clear();
            			Console.WriteLine(menu);
            			 opc = int.Parse(Console.ReadLine());
            			
            			break;
            		case 4:
            			VerificarListaTecnicos(mov);
            			ListaAreas(mov);
            			Console.WriteLine("Ingrese el area que desee para ver el nombre del tecnico asignado a la misma");
            			int a= int.Parse(Console.ReadLine());
            			ImprimirTecArea(mov, a);
            			Console.Clear();
            			Console.WriteLine(menu);
            			opc = int.Parse(Console.ReadLine());
            			
            			break;
            		case 5:
            			VerificarListaClientes(mov);
            			ImprimirListaCliente(mov);
            			Console.ReadKey();
            			Console.Clear();
            			Console.WriteLine(menu);
            			opc = int.Parse(Console.ReadLine());
            			
            			break;
            		case 6:
            			AgregarTecnico(mov);
            			Console.Clear();
            			Console.WriteLine(menu);
            			 opc = int.Parse(Console.ReadLine());
            			
            			break;
            		case 7:
            			VerificarListaClientes(mov);
            			Console.WriteLine("Lista de clientes: \n");
            			ImprimirListaCliente(mov);
            			Console.WriteLine("ingrese el numero de cliente para ver facturacion");
            			int numclientill=int.Parse(Console.ReadLine());
            			ImprimirFacturacion(numclientill,mov);
            			Console.Clear();
            			Console.WriteLine(menu);
            			 opc = int.Parse(Console.ReadLine());
            			
            			break;
            		case 8:
            			VerificarListaTecnicos(mov);
            			ImprimirListaTec(mov);
            			Console.Clear();
            			Console.WriteLine(menu);
            			 opc = int.Parse(Console.ReadLine());
            			
            			
            			break;
            		default:
            			break;
            	}
            }
            }
            catch(Exception){
            	Console.ForegroundColor=ConsoleColor.Red;
            	Console.WriteLine("Se ha producido un error! Intente denuevo e ingrese un numero");
            	Console.ForegroundColor=ConsoleColor.Gray;
            	goto origen;
            }
            



            Console.WriteLine("Presione cualquier tecla para salir");
			Console.ReadKey();
		}

public static void AgregarCliente(empresa n)
        {
            int dni, minutodecomuni,area;
            string nombre, apellido, combovigente;
            DateTime fecha=new DateTime();
            bool comboplus;
            ArrayList listatec=new ArrayList();
            listatec=n.todoslostecnicos();
           string tecniconom;
           ArrayList datosArea=new ArrayList();
            double precioclcomb=0.0;
           
           datos:
            try{
      
            dni=verificardni();
            while(dni!=0){
          
       
            String[] d1= verificarNombreAp().Split(' ');
  
            nombre=d1[0];
            apellido=d1[1];
    
            fecha=VerificarFecha();
            
            minutodecomuni=verificarnumcomu();

            datosArea= AgregarTecnicoSegArea(n);//me va a retornar un nombre de tecnico
            area=(int)datosArea[0];
            tecniconom=(string)datosArea[1];
      
            //comboplus=VerSitieneComboP(n,fecha);

            combovigente=verificarIngCombos();
            precioclcomb=PrecioSComb(combovigente,n);
            cliente clie1=new cliente(nombre,apellido,dni,fecha,minutodecomuni, tecniconom, area,combovigente,precioclcomb );
            comboplus=VerSitieneComboP(n,clie1);
            Console.ReadKey(true);
            
           cliente clie2=new cliente(nombre,apellido,dni,fecha,minutodecomuni, tecniconom, area,comboplus,combovigente,precioclcomb );
            n.VerificarNumeroCliente(clie1, clie1.Num_cliente);
            Console.Clear();
            clie1.ImprimirCliente();
            n.agregarcliente(clie1);
            Console.WriteLine("***************");
            Console.ReadKey(true);
            Console.Clear();
			dni=verificardni();
            
            }

        }
           
            catch (Exception){
            	Console.WriteLine("Ha ingresado un dato incorrecto, intentelo nuevamente");
            	goto datos;
            	
            }
            
}
      
public static void EliminarCliente(empresa p, int numc){
	ArrayList listaclient=new ArrayList();
	listaclient=p.todoslosclientes();
	foreach (cliente x in listaclient){
		if (numc== x.Num_cliente){
			p.eliminarcliente(x);
			Console.WriteLine("cliente eliminado!");
			break;
		}
	}
	Console.ReadKey(true);
}

public static void ImprimirTecArea(empresa v, int area){
	ArrayList listatecn= new ArrayList();
	listatecn=v.todoslostecnicos();
	foreach(tecnico te in listatecn){
		if(te.Area==area){
		te.ImprimirTecnico();
		}
	}
	Console.ReadKey(true);
	
}

public static void ImprimirListaCliente(empresa e){
	ArrayList listclien= new ArrayList();
	listclien=e.todoslosclientes();
	for(int x=0; x<e.cantidadcliente();x++){
		e.vercliente(x).ImprimirCliente();
	}
	
//	Console.ReadKey(true);
}

public static void AgregarTecnico(empresa el){
	int are;
	string d2, n,a;
dats:
	try{

	are=verificarArea(el);
	while(are!=0){
	
	d2=verificarNombreAp();
	String[] date=d2.Split(' ');
	 n= date[0];
	 a=date[1];
	
	tecnico p= new tecnico(n,a,are);
	el.VerificarNumeroTecnico(p,p.Numtec);
	el.agregartecnico(p);
	Console.ForegroundColor=ConsoleColor.Green;
	Console.WriteLine("tecnico añadido!");
	Console.ForegroundColor=ConsoleColor.Gray;
	Console.WriteLine("Escribi el Area o 0 para salir");
	are=int.Parse(Console.ReadLine());
    }
	}
	catch (Exception){
		Console.WriteLine("dato mal ingresado, vuelva a cargarlo");
		goto dats;
	}
   // Console.ReadKey(true);
}

public static void ImprimirListaTec(empresa v){
	ArrayList listaTe= new ArrayList();
	listaTe= v.todoslostecnicos();
	for(int i=0; i<v.cantidadtecnico(); i++){
		v.Vertecnico(i).ImprimirTecnico();
	}
	Console.ReadKey(true);
	

}

public static void ModificarMinCons(empresa m, int numc){
	ArrayList listac= new ArrayList();
	listac=m.todoslosclientes();
	foreach(cliente x in listac){
		if (numc == x.Num_cliente){
			Console.WriteLine("cuantos minutos consumió?");
			int min= int.Parse(Console.ReadLine());
			x.Minconsumido=min;
			x.ImprimirCliente();
			Console.ReadKey(true);
			break;
		}
		
	}
	Console.ReadKey(true);
}

public static ArrayList AgregarTecnicoSegArea(empresa n){

	int area;
	ArrayList data=new ArrayList();
	ArrayList listatch=new ArrayList();
    listatch=n.todoslostecnicos();
   bool existe=false;
zona:
	try{
		Console.WriteLine("Ingrese el Area del cliente");
		ListaAreas(n);
        area= int.Parse(Console.ReadLine());
        Console.WriteLine("asignando tecnico...");
        if(!existe){
        	foreach(tecnico t in listatch){
        		if(area==t.Area){
        		existe=true;
        		data.Add(area);
        	    data.Add(t.Nombre);
        	    Console.WriteLine("Tecnico asignado! Su tecnico es {0}",t.Nombre);
        		break;
        		
        	}
        		
        }
        }
        if(existe==false){
        	throw new Exception();
        }
        	return data;
            
        }
	catch(Exception){
		Console.WriteLine("No existe un tecnico para esa area, ingrese uno");
		AgregarTecnico(n);
		goto zona;
		
	}
}

public static double PrecioSComb(string combovig, empresa p){
        	ArrayList listadcom= new ArrayList();
        	listadcom=p.PrecioCombos;
        	double preciocombcl=0.0;
        	
        	foreach(double precio in listadcom){
            	if(combovig=="combo 1"){
            		preciocombcl=(double)listadcom[0];
            	}
            	if(combovig=="combo 2"){
            		preciocombcl=(double)listadcom[1];
            	}
            	if(combovig=="combo 3"){
            		preciocombcl=(double)listadcom[2];
            	}
            	if(combovig=="combo 4"){
            		preciocombcl=(double)listadcom[3];
            	}
        			
            }
        	return preciocombcl;
        	
        }
	
//public static bool VerSitieneComboP(empresa m){
//	DateTime hoy=new DateTime();
//	hoy=DateTime.Now;
//	DateTime fechalim=m.FechaLimitePromo;
//	int result=DateTime.Compare(hoy, fechalim);
//	bool combp=false;
//	try{
//	if(result<0){
//			if(m.cantidadcliente()<m.CupoPromocion){
//			combp=true;
//			Console.WriteLine("Cliente tiene combo plus");
//		}
//		    else{
//				throw new Exception();	
//			}
//	}
//	else{
//			throw new Exception();
//		}
//	}
//	catch(Exception){
//			Console.WriteLine("No puede tener combo plus");
//		}
//	return combp;
//}
public static bool VerSitieneComboP(empresa m,cliente c1){
	DateTime hoy=new DateTime();
	hoy=c1.Fecha;
	DateTime fechalim=m.FechaLimitePromo;
	int result=DateTime.Compare(hoy, fechalim);
	bool combp=false;
	try{
	if(result<0){
			if(m.cantidadclienteconcp()<m.CupoPromocion){
			combp=true;
			m.agregarclientecp(c1);
			Console.WriteLine("Cliente tiene combo plus");
		}
		    else{
				throw new Exception();	
			}
	}
	else{
			throw new Exception();
		}
	}
	catch(Exception){
			Console.WriteLine("No puede tener combo plus");
		}
	return combp;
}

public static void ImprimirFacturacion(int numc, empresa v){
	ArrayList listaclie=new ArrayList();
	listaclie=v.todoslosclientes();
	double precio=0.0;
	foreach(cliente a in listaclie){
		if(numc==a.Num_cliente){
			
			precio=a.PrecioCombo;
			if(a.Combovigente=="combo 1"){
				if(a.Minconsumido<2550){
					Console.WriteLine("aplica al descuento");
					precio=1700.0;
				}
				else{
					Console.WriteLine("no aplica al descuento");
				}
			}
			if(a.Combovigente=="combo 2"){
				if(a.Minconsumido<4250){
					Console.WriteLine("aplica al descuento");
					precio=2550.0;
				}
				else{
					Console.WriteLine("no aplica al descuento");
				}
			}
			if(a.Combovigente=="combo 3"){
				if(a.Minconsumido<5100){
					Console.WriteLine("aplica al descuento");
					precio=3400.0;
				}
				else{
					Console.WriteLine("no aplica al descuento");
				}
			}
			if(a.Combovigente=="combo 4"){
				if(a.Minconsumido<6800){
					Console.WriteLine("aplica al descuento");
					precio=4250.0;
				}
				else{
					Console.WriteLine("no aplica al descuento");
				}
			}
		}
	}
	Console.WriteLine("La facuracion del cliente es: ${0}",  precio);
	Console.ReadKey(true);
	
}
public static void VerificarListaClientes(empresa emp){
	
	try{
		if(emp.cantidadcliente()==0){
			throw new Exception();
		}
		
	}
	catch(Exception){
		Console.WriteLine("No hay clientes ingresados, por favor ingrese uno");
		AgregarCliente(emp);
	}
	
}
public static void VerificarListaTecnicos(empresa empre){
	try{
		if(empre.cantidadtecnico()==0){
			throw new Exception();
		}
		
	}
	catch(Exception){
		Console.WriteLine("No hay tecnicos ingresados, por favor ingrese uno");
		AgregarTecnico(empre);
	}
	
}
public static void ListaAreas(empresa empresi){
	ArrayList listaTech=new ArrayList();
	listaTech=empresi.todoslostecnicos();
	Console.WriteLine("Las areas existentes son:");
	foreach(tecnico tecns in listaTech){
		Console.WriteLine(tecns.Area);
	}
	

}

public static int verificardni(){
	int dni;
	back:
		try{
		    Console.WriteLine("ingrese el dni o 0");
            dni=Int32.Parse(Console.ReadLine());
            return dni;
	}
	
	catch(Exception){
		Console.WriteLine("dni ingresado no es valido, intentelo denuevo");
		goto back;
	}
}

public static string verificarNombreAp(){
   string datos;
	backdat:
		try{
		    Console.WriteLine("ingrese el nombre y apellido en el formato NN AA");
		    datos=Console.ReadLine();
            return datos;
	}
	
	catch(Exception){
		Console.WriteLine("datos mal ingresados, intente en el siguiente formato NN AA");
		goto backdat;
	}
	
}

public static DateTime VerificarFecha(){
	DateTime fecha;
bfecha:
	try{
	Console.WriteLine("ingrese la fecha de alta en el siguiente formato dd/mm/aa");
    fecha=DateTime.Parse(Console.ReadLine());
    return fecha;
	}
	catch(Exception){
		Console.WriteLine("fecha mal ingresada, intentelo denuevo en el formato dd/mm/aa");
		goto bfecha;
	}
}
public static int verificarnumcomu(){
	int numscom;
	backw:
		try{
		    Console.WriteLine("ingrese los minutos de comunicacion del cliente");
            numscom=Int32.Parse(Console.ReadLine());
            return numscom;
	}
	
	catch(Exception){
		Console.WriteLine("minutos ingresados no son válidos, intentelo denuevo");
		goto backw;
	}
}
public static string verificarIngCombos(){
	string combovigente;
	bool es=false;
	backw:
		try{
		   Console.WriteLine("ingrese el combo vigente ('combo 1', 'combo 2', 'combo 3', 'combo 4')");
           combovigente=Console.ReadLine();
           if(!es){
           	if(combovigente=="combo 1"){
           	es=true;
           	
           }
           if(combovigente=="combo 2"){
           	es=true;
           	
           }
           if(combovigente=="combo 3"){
           	es=true;
           	
           }
           	if(combovigente=="combo 4"){
           es=true;
           
           }
           }
           if(es==true){
           	return combovigente;
           }
           else{
           	throw new Exception();
           	}
           
	}
	
	catch(Exception){
		Console.WriteLine("Dato mal cargado, ingreselo denuevo en el formato 'combo N'");
		goto backw;
	}
}
public static int verificarArea(empresa emp){
	int are;
	ArrayList listat=new ArrayList();
	listat=emp.todoslostecnicos();

gtac:
		bool ex=false;
	try{
		Console.WriteLine("Escribi el Area o 0 para salir");
	    are=int.Parse(Console.ReadLine());
	    if(!ex){
	    	foreach(tecnico t in listat){
	    		if(t.Area==are){
	    			ex=true;
	    		}
	    		
	    	}
	    }
	    if(ex==true){
	    	throw new Exception();
	    }
	    return are;
	}
	catch (Exception){
		Console.WriteLine("Area asignada a otro tecnico, por favor ingrese otra");
		goto gtac;
	}
		
}

}
}