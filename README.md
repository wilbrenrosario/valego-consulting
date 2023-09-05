## Comentario
Saludos!,

Espero haber entendido correctamente las instrucciones, pense utilizar Angular para el cliente, pero lo descarte ya que no estaba como opcion en la solicitud, en este proyecto con .net 7 y sql server, se integro las tecnologias y patrones de diseño mencionados mas abajo. En el proyecto podras ver una soluccion donde tienes la opcion de indicarle al proyecto de iniciar con la solucion [valego.api] la cual te levantara una API con swagger haciendo uso del consumo de enpoint y la muestra de data desde su db.

Y tambien de manera visual tienes una solucion [valego.web.mvc] sencilla, que de manera visual muestra la data desde su DB, actualiza/llena la base de datos haciendo consulta al enpoint externo y un pequeño filtro mediante sus titulos.

Dejare muestras de imagenes igualmente. En fin, espero sea de su agrado.

# Tecnologias y herramientas
* .Net Core 7
* Clean Architecture
* WEB MVC
* CQRS
* DI
* Consumo de api rest
* Base de datos SQL Server
* ENPOINT: https://www.bitmex.com/api/explorer/#!/Announcement/Announcement_get



# Visuales
![estructura](https://github.com/wilbrenrosario/valego-consulting/assets/41119318/6cecde76-ed70-4b70-a54b-ede7fd65d873)

![api](https://github.com/wilbrenrosario/valego-consulting/assets/41119318/2091bbf5-141d-4b0f-8755-d5290a6be335)

![web mvc](https://github.com/wilbrenrosario/valego-consulting/assets/41119318/573dfcb8-d791-47b9-834a-ad79a84a02db)





# valego-consulting

 **devTest Backend**
 
We want to understand better how good you are integrating several technologies to provide a solid solution, this is a sample project that will help ilustrate just that.

**Exchange rate per symbol**

We would like to generate a solution that provides exchange information and general information of the sample platform selected to the end users.

1. Fork this project and invite me (starl1n), you are going to work on the branch you just created and submit your changes there.
2. Create a connection to these endpoints using the required technology:


**WEB API:**
https://www.bitmex.com/api/explorer/#!/Announcement/Announcement_get

3. Present the data in REST endpoints fashion 
4. Store the records received from the connection into a database SQL Server/MariaDB/MongoDB/Postgres/etc
5. In a separated section of the solution provide a way to search or filter for the results stored in the Database of choice sorted by date in decending order, maybe you can add any sort of filter here too.

Provide the scripts of databases if are going to be public 

**This test will evaluate:**
1. REST API consumption capabilities
2. Knowledge of API integration between databases/API
3. Familiarity with the language


If you are unfamiliar with any part of the request, is fine, you can skip it **(but make a comment )**
