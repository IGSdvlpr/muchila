public class HomeController : Controller
    {

        // GET: Home
        [HttpGet]
        public ActionResult Index() {
            Debug.WriteLine(":::::Index:::::");
            ViewData["error"] = "ok";
            BD.per = new Persona();
            return View();           
        }

        [HttpPost]
        public ActionResult Index(FormCollection formulario) {
            string correo = formulario["correo"].ToString();
            string clave = formulario["clave"].ToString();
            bool logIn = false;
            Persona per = new Persona();
            //buscar la persona y enviar la lista de despensa
            logIn= BD.Loguear(correo, clave);


            if (logIn) {
                ViewData["error"] = "ok";                
                ViewBag.per = per;                
                return RedirectToAction("Despensa");
            } else {
                ViewData["error"] = "Usuario o Contraseña incorrecto";
            }

            return View();
        }



        [HttpGet]
        public ActionResult Despensa() {
            Debug.WriteLine(":::::DESPENSA:::::");

            BD.listaProductos.Clear();
            BD.listaStock.Clear();
            BD.listaCompras.Clear();
            

            int id = BD.per.Id;
            BD.Listar(id);
            
            return View(BD.listaProductos);
        }



        [HttpGet]
        public ActionResult Editar(int id) {
            Debug.WriteLine(":::::EDITAR PRODUCTO:::::");

            //buscar el producto con este id
            BD.BuscarPro(id);

            return View(BD.pro);            

            
        }

        [HttpPost]
        public ActionResult Editar(FormCollection formulario) {

            int despId = BD.pro.Id;
            string nombre = formulario["Nombre"].ToString();
            string nuevoValor = formulario["Cantidad"].ToString();
            string vista = "E";
            //validar la entraada numerica para que siempre sea entero positivo

            //validar la entrada "nombre" para que sea unico

            //parsear los datos            
            int nuevValor = Int32.Parse(nuevoValor);
            
            if (BD.EditarP(despId, nuevValor,vista)) {
                ViewData["Editar"] = "Se ha modificado con exito";
                //actualizar la base de datos y las listas                
                BD.Listar(BD.per.Id);                

            } else {
                ViewData["Editar"] = "Ha ocurrido un error inesperado, intente mas tarde.";                
                
            }
            Thread.Sleep(2000);        

            return RedirectToAction("Despensa");
        }





        //eliminar
        [HttpGet]
        public ActionResult Eliminar(int id) {
            Debug.WriteLine(":::::ELIMINAR:::::");
            //buscar el producto con ese id en BD y devolver un obj tipo producto
            if (BD.BuscarPro(id)) {
                
                ViewData["NoExiste"] = "Existe";               
                return View(BD.pro);

            } else {
                ViewData["NoExiste"] = "El producto que esta iuntentando editar no existe.";
                Thread.Sleep(3000);                
                return RedirectToAction("Despensa");
            }
            
        }

        [HttpPost]
        public ActionResult Eliminar(Producto prodructo) {
            //recuperar el dato 
            var id = prodructo.Id;

            //eliminar
            if (BD.Eliminar(id)) {
                ViewData["Eliminar"] = "Se ha eliminado con éxito";                
                return RedirectToAction("Despensa");
            } else {
                ViewData["Eliminar"] = "Ha ocurrido un error inesperado, intente mas tarde.";                
                return RedirectToAction("Despensa");
            }
            
        }



        [HttpGet]
        public ActionResult CrearProducto() {
            Debug.WriteLine(":::::CREAR PRODUCTO:::::");
            ViewData["Crear"] = "";
            Producto pro = new Producto();
            return View(pro);
        }

        [HttpPost]
        public ActionResult CrearProducto(FormCollection formulario) {
            
            string nombre = formulario["Nombre"].ToString().ToUpper();
            string cantidad = formulario["Cantidad"].ToString();
            string stock1 = formulario["Stock"].ToString();
            int id = 0;
            bool estado = false;
            //crear un objeto de tipo despensa

            int idUsu = BD.per.Id;                       
            int cant = Int32.Parse(cantidad);
            int stock = Int32.Parse(stock1);

            id = BD.ObtenerId(nombre);

            if(id != 0) {
                Debug.WriteLine("--> Ya existe un producto con este nombre, intentalo de nuevo");
                ViewData["Crear"] = "Ya existe un producto con este nombre, intentalo de nuevo";
                Thread.Sleep(2000);
                return RedirectToAction("Despensa");
                

            } else {
                BD.CreaProd(nombre);
                id = BD.ObtenerId(nombre);
                if(id != 0) {
                    estado = BD.InsertaDesp(id, cant, idUsu, stock);
                }
                if (estado) {
                    Debug.WriteLine("--> se creó el producto correectamente");
                    ViewData["Crear"] = "Se creo el nuevo producto con exito";
                    Thread.Sleep(2000);
                    return RedirectToAction("Despensa");
                } else {
                    Debug.WriteLine("--> Hubo un problema al crear el producto intentelo nuevamente");
                    ViewData["Crear"] = "Hubo un problema al crear el producto intentelo nuevamente";
                    Thread.Sleep(2000);
                    return RedirectToAction("Despensa");
                }        
            }
        }



        //stock
        [HttpGet]
        public ActionResult Stock() {
            Debug.WriteLine(":::::STOCK:::::");

            return View(BD.listaStock);

        }
        
        [HttpGet]
        public ActionResult EdStock(int id) {
            Debug.WriteLine(":::::EDITAR STOCK:::::");

            BD.BuscarPro(id);
            
            return View(BD.pro);

        }


        [HttpPost]
        public ActionResult EdStock(FormCollection formulario) {
            string idDesp = formulario["Id"].ToString();
            string stock = formulario["Stock"].ToString();
            string vista = "S";
            int id = Int32.Parse(idDesp);
            int nuevoValor = Int32.Parse(stock);


            if (BD.EditarP(id, nuevoValor, vista)) {
                ViewData["Exito"] = "Se ha modificado con exito";
            } else {
                ViewData["Exito"] = "Ha ocurrido un error inesperado, intente mas tarde.";
            }           

            return RedirectToAction("Stock");
        }




        [HttpGet]
        public ActionResult ListaDeCompras() {
            Debug.WriteLine(":::::LISTA DE COMPRAS:::::");

            return View(BD.listaCompras);

        }

        [HttpPost]
        public ActionResult ListaDeCompras(FormCollection formulario) {
            Debug.WriteLine(":::::LISTA DE COMPRAS CALCULAR TOTAL:::::");
            string val1 = formulario["Precio"].ToString();
            Debug.WriteLine("precio" + val1);



            return View();

        }





    }