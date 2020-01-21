# AI-Navmeshes
Modifica el proyecto "Agentes en el Nav Mesh" para incluir un First Person Controller, de forma que tres tipos distintos de agente persigan al jugador. Crea tipos de agentes con propiedades diferentes para que se generen NavMeshes diferentes para cada tipo, de forma que tengan que buscar caminos alternativos para perseguir al jugador.

Opcional: en lugar de usar cápsulas, descarga modelos 3D de Mixamo (o de otra fuente) y anímalos con los scripts que hemos usado para que se adapte su movimiento al del Nav Mesh Agent.

---

Utilicé modelos 3D de robots descargados de TurboSquid y les asigné una animación de levitar. Tanto la velocidad de la animación como la velocidad del robot depende de su tamaño (generado aleatoriamente, así como otras propiedades del Nav Mesh Agent), generando coherencia visual e individualidad para cada agente.

![](Gif-AINavmeshes.gif)
