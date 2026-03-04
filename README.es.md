![License: MIT](https://img.shields.io/badge/Licencia-MIT-green)
![University: IUT Montreuil](https://img.shields.io/badge/IUT%20Montreuil-Informática-red)
![Engine: Unity](https://img.shields.io/badge/Unity-5.x-lightgrey)
![Language: C#](https://img.shields.io/badge/C%23-7.0-blueviolet)
![Project Type](https://img.shields.io/badge/Juego-Infiltración-blue)
![Contributors](https://img.shields.io/badge/colaboradores-4-orange)
![Stars](https://img.shields.io/github/stars/Fab16BSB/Infiltration?color=orange)
![Fork](https://img.shields.io/github/forks/Fab16BSB/Infiltration?color=orange)
![Watchers](https://img.shields.io/github/watchers/Fab16BSB/Infiltration?color=orange)

# 🕵️ Infiltration

## 🌍 Versiones del README en otros idiomas

| 🇫🇷 Français | 🇬🇧 English | 🇪🇸 Español |
|-------------|------------|------------|
| [README.fr.md](./README.fr.md) | [README.md](./README.md) | ¡Estás aquí! |

---

## 📘 Resumen del Proyecto

Este proyecto fue realizado durante el **segundo año del Grado en Informática (DUT)** en el **IUT de Montreuil** en 2016. Fue el proyecto final para el curso de **Desarrollo de Videojuegos**.

Fuimos un equipo de **4 estudiantes**. El objetivo era diseñar un juego de infiltración completo utilizando **Unity** y **C#**.

> ⚠️ El juego está **disponible exclusivamente en francés**.

---

## 🎭 La Historia: "La idea robada"

Te presentas a una entrevista para unas prácticas en **Woodle**, una reconocida empresa tecnológica. Durante la entrevista, les presentas una idea de proyecto revolucionaria.

La empresa decide no contratarte... ¡pero pronto descubres que han **robado tu idea** para desarrollarla ellos mismos!

¡Injusticia! Decides tomar cartas en el asunto. Tu misión: **infiltrarte de noche en las oficinas de Woodle** bajo diversas identidades secretas. Tu objetivo final es acceder al servidor central para **borrar todo rastro de tu proyecto** y evitar que la empresa se apropie de tu trabajo.

---

## 🕹️ Presentación del Juego

**Infiltration** combina narrativa, estrategia y sigilo:

- **Sistema de Identidades (Vidas):** Tus identidades son tus "vidas". Si te descubren, pierdes tu cobertura y debes regresar bajo una **nueva identidad** para continuar la misión.
- **Sigilo y Discreción:**
    - **Visual:** Evita los conos de visión de los guardias.
    - **Auditivo:** Se incluye un sistema de **ruido**. Camina con cuidado; los pasos pesados pueden alertar a los guardias cercanos.
- **Escondites Tácticos:** Puedes esconderte en **cubos de basura** para escapar de la vigilancia, pero ¡cuidado!: ¡esto solo es posible si ningún enemigo te ha visto todavía!
- **Narrativa:** Un modo tutorial guionizado que presenta la entrevista de trabajo y la traición de la empresa.
- **Niveles Variados:** Cada miembro del equipo diseñó desafíos específicos para poner a prueba tus reflejos y paciencia.

### ⚠️ Un verdadero desafío
El juego ofrece una **dificultad exigente**:
* **Enemigos astutos:** Algunos guardias tienen comportamientos impredecibles y no será fácil esquivarlos.
* **Sin escondites si te detectan:** Si un enemigo ya te tiene en su campo de visión, es demasiado tarde para esconderse en un cubo de basura. Debes permanecer fuera de la vista ANTES de buscar refugio.

---

## ⚙️ Tecnologías Utilizadas

- **Motor de juego:** Unity (Versión 2016)
- **Lenguaje:** C#
- **Plataforma:** Windows (x86)

---

## 💻 Instalación y Ejecución

### 🚀 Jugar inmediatamente (Versión Release)

Una versión lista para jugar (Build) está disponible en la sección de **Releases** de este repositorio.

1. Ve a la pestaña de [Releases](https://github.com/Fab16BSB/Infiltration/releases/tag/v1.0).
2. Descarga el archivo `Infiltration_Archive.zip`.
3. Extrae el archivo (contiene el `.exe`, la carpeta `_Data` y archivos de depuración `.pdb`).
4. Ejecuta **infiltration.exe**.

### 🛠️ Abrir el Proyecto (Código Fuente)

Para explorar los scripts o escenas:
1. Clona este repositorio.
2. Abre la carpeta con **Unity Hub** (se recomienda la versión 5.x para mayor compatibilidad).

---

## ⌨️ Mandos y Controles

El juego ofrece una gran flexibilidad para adaptarse a tu estilo, seas diestro o zurdo.

### 🏃 Movimiento y Acciones
| Acción | Teclas (Diestro) | Teclas (Alternativa / Zurdo) |
| :--- | :--- | :--- |
| **Moverse** | `W` `A` `S` `D` | `Teclas de dirección` (↑ ← ↓ →) |
| **Correr** | `Shift Izquierdo` | `Shift Derecho` |
| **Ralentizar / Sigilo** | `Ctrl Izquierdo` | `Ctrl Derecho` |
| **Abrir Puerta** | `Espacio` | `Espacio` |

> 💡 **Consejo:** Correr genera mucho ruido (`XX`), mientras que caminar manteniendo pulsado `Ctrl` te permite ser totalmente silencioso (`--`).

### 🎧 Inmersión Sonora
El juego incluye una **ambientación sonora completa**. El sonido es un elemento fundamental: ¡escucha con atención los pasos de los guardias y las alarmas para anticipar el peligro!

### 🚪 Cómo salir del juego
* **Método recomendado:** Usa el atajo `Ctrl` + `Alt` + `Tab` para salir de la ventana y cierra la aplicación manualmente.

---

## 🎮 Vista previa del juego

### Menú Principal
La interfaz de inicio del juego donde puedes lanzar la misión de infiltración.
![Menú Principal](images/main_menu.png)

---

### Fase de Tutorial
El juego comienza con una fase narrativa para aprender los conceptos básicos del sigilo.
![Tutorial - Inicio](images/tutoriel1.png)
*Objetivo: Accede al ordenador principal en la última planta.*

---

### Infiltración y Vigilancia
Una vez dentro de las oficinas de Woodle, la vigilancia es clave. Los guardias patrullan con conos de visión dinámicos cuyo color indica su estado de alerta.

![Nivel 1 - Guardias](images/lvl1_1.png)
*Esquiva el campo de visión de los guardias para mantener intacta tu identidad.*

![Nivel 1 - Exploración](images/lvl1_3.png)
*Recoge el mapa para revelar la ubicación de los objetos cercanos.*

---

### 👮 Comportamiento de los Enemigos

El sistema de detección se basa en una gestión avanzada de la visión y el oído de los guardias. Presta atención al color de su haz y a los iconos de alerta:

* **Patrulla (Haz Amarillo):** El estado normal del guardia. Sigue su ruta predefinida, sin sospechar tu presencia.
* **Sospecha Sonora (Haz Rojo + `?`):** Los guardias son sensibles al ruido (marcado con `X` o `XX` en tu interfaz). Si escuchan un sonido, abandonan su patrulla para ir inmediatamente a la **ubicación exacta** del ruido para investigar.
* **Detección Visual (Haz Rojo + `!`) :** Si entras en el campo de visión de un guardia, te identifica formalmente. Tu identidad actual se ve comprometida y pierdes una "vida".
* **Sueño (Haz Violeta):** Puedes encontrar guardias dormidos. No ven nada, pero ¡mantén el silencio!, un ruido fuerte puede despertarlos al instante.

### 📸 Estados de alerta en acción

![Alerta Sonora](images/lvl1_4.png)  
*Un haz rojo con un **?** indica que el enemigo escuchó un ruido sospechoso y se mueve para revisar la zona.*

![Detección Inmediata](images/lvl1_5.png)  
*Un haz rojo con un **!** señala una detección visual inmediata: has sido descubierto.*

---

### Sistema de Escondites
Una mecánica esencial para sobrevivir, sujeta a condiciones estrictas.
![Sistema de Basura](images/lvl1_2.png)
*Puedes esconderte en los cubos de basura, pero solo si no estás ya en el campo de visión de un enemigo.*

---

### Detalles de la interfaz (HUD)
La interfaz del juego muestra información crucial para tu supervivencia:

* **Identidades (Vies):** En la parte superior izquierda, indican el número de coberturas restantes.
* **Indicador de Ruido:** En la parte superior derecha, cambia según tus acciones:
    * `--`: Estás en total silencio.
    * `X`: Ruido ligero, ten cuidado con los guardias cercanos.
    * `XX`: Ruido fuerte, corres el riesgo de alertar a toda la zona.
* **Inventario:** Visualiza tus objetos de misión y tarjetas de acceso en tiempo real.

---

## 🧑‍💻 El Equipo

Cuatro de nosotros trabajamos en este proyecto con la siguiente distribución:

- **Boris Eng**: Coautor de la historia, creación del tutorial y diseño de todos los entornos/decorados.
- **Thomas Dunglas**: Creación del HUD (Interfaz de Usuario) y diseño de un nivel completo.
- **Lucas**: Diseño y creación de un nivel completo.
- **Yo**: Coautor de la historia, creación del tutorial y mecánicas de juego.

---

## 🙌 Agradecimientos

Me gustaría agradecer a mis profesores del IUT de Montreuil por proponernos este proyecto y por sus valiosos consejos técnicos durante el curso.