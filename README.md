
### PROYECTO "HOLA MUNDO"

Este proyecto es una aplicaci�n de Windows Forms que valida contrase�as seg�n los siguientes requisitos:

- La contrase�a debe contener al menos una letra may�scula, 
- Una min�scula. un n�mero y un s�mbolo.
- El usuario debe ingresar la contrase�a dos veces y ambas deben coincidir.

### Funcionamiento principal
------------
En el formulario principal (`Form1`), al hacer clic en el bot�n, se ejecuta la validaci�n de la contrase�a ingresada en `textBox1` y su confirmaci�n en `textBox2`. Si la contrase�a cumple con los requisitos y ambas coinciden,
se muestra un mensaje de �xito. Si no, se informa al usuario del error correspondiente.

La validaci�n se realiza mediante una expresi�n regular y comparaciones simples.

### Se anexa el codigo, comentarios y Evidencia del funcionamiento:

------------

    
	// Importaci�n de librer�as
    using System;											//funciones basicas del sistema
    using System.Text.RegularExpressions;	//trabaja con expresiones regulares
    using System.Windows.Forms;				 //crear aplicaciones de Windows Forms
	

------------


    
	// Define el contenedor l�gico del proyecto,
	//Aqu� se agrupan clases relacionadas 
    namespace WindowsFormsApp1    
    {
        public partial class Form1 : Form
        {
            public Form1()
			

------------

    
	//carga los controles visuales definidos en el dise�ador
	//asocia el evento de clic del bot�n button1 con el m�todo Button1_Click
            {
                InitializeComponent();
                button1.Click += Button1_Click;
            }
    //Evento de carga del formulario
            private void Form1_Load(object sender, EventArgs e)
            {
    

------------


            }
    //Evento de clic del bot�n, es donde se ejecuta el nucleo de la logica
            private void Button1_Click(object sender, EventArgs e)
            {
                string password = textBox1.Text;				//obtiene el texto Contrase�a
                string confirmPassword = textBox2.Text;	//obtiene el segundo texto confirmacion
    
                // Expresi�n regular: al menos una may�scula, una min�scula, 
				//un n�mero y un s�mbolo
                string pattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[\W_]).+$";
							// Esta expresion regula lo siguiente
							// Que la contrase�a contenga:
							// - Al menos una letra may�scula ([A-Z])
							// - Al menos una letra min�scula ([a-z])
							// - Al menos un n�mero (\d)
							// - Al menos un s�mbolo o car�cter especial ([\W_])
							
				//valida la contrase�a contra el patr�n definido
                if (!Regex.IsMatch(password, pattern))
                {
				// Si la contrase�a no cumple con el patr�n, 
				//muestra un mensaje de error y termina la ejecuci�n del m�todo
                    MessageBox.Show("La contrase�a no cumple con los requisitos.");
                    return;
                }
    
				// Verifica si las contrase�as coinciden
                if (password != confirmPassword)
                {
				 // Si las contrase�as no coinciden,
				 //muestra un mensaje de error y termina la ejecuci�n del m�todo
                    MessageBox.Show("Las contrase�as no coinciden.");
                    return;
                }
				// Si la contrase�a es v�lida y las contrase�as coinciden, 
				//muestra un mensaje de �xito
                MessageBox.Show("La contrase�a ha sido validada");
            }
        }
    }
    


#### Se anexa imagenes de la ejecucion del codigo :
    

![Captura](Imagen/captura01.jpg "Captura")

