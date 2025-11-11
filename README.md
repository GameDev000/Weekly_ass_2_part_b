# Weekly_Assignment_2_Part_A_Oscillator

### What this project is
A simple 2D Unity project where the player moves around using the arrow keys and sees their current position on a small **mini-map** in the top-right corner of the screen.  
The project also demonstrates how to keep the visual scale of objects consistent when rotating the device between **landscape** and **portrait** modes.

---

### How to play
- **Movement:** Use the arrow keys to move the player.  
- **Mini-map:** The mini-map is displayed on a **Canvas**, showing a small dot that represents the player's position in real time.  
- **Goal:** Simply move around and watch your position update on the mini-map.

---

### Mini-map
- The mini-map is built using a **UI Canvas** placed on top of the main view.  
- Inside the Canvas, there’s a small **dot (UI element)** that represents the player.  
- A script updates the dot’s position on the map according to the player’s world coordinates, keeping it in sync with movement.

---

### Camera and rotation (the problem and the solution)
- The main camera is **Orthographic**, which means it displays a fixed portion of the 2D world.  
- The **Size** property of the camera defines how much of the world is visible vertically.  
- When rotating the phone or simulator, the **aspect ratio** of the screen changes — it becomes taller in portrait mode or wider in landscape mode.  
- If the camera’s **Size** remains fixed, the visible area changes and objects appear larger or smaller.

**Solution:**  
The camera’s orthographic size is adjusted automatically whenever the orientation changes.  
By recalculating the size based on the new aspect ratio, the game keeps all objects the same visual size on screen, avoiding zoom-in or zoom-out effects.

---

### Scene components
- **Player** – moves using the arrow keys.  
- **Main Camera** – Orthographic camera that adjusts its size dynamically when the device rotates.  
- **Canvas (Mini-map)** – displays a small dot representing the player's position, updated in real time.

  <a href="https://itamar000.itch.io/weekly-ass-2-part-b">itch.io</a>
