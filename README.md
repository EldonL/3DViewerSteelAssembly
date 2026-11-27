# 3DViewerSteelAssembly

# Unity version and scene to open
- Unity version 2022.3.62f3
- Scene to open: Assets\ _3DViewerSteelAssembly\Scenes\main

# A short explanation of how you organised the code, and why.
- Setup MVC design pattern (model not setup). Reasoning: This allows me to receive all the events from the controller. I can choose which view (aka screen) to open from the controller. The View can choose which elements (sidebar, buttons) to open. Allows scalability in case the same/different view needs to be opened closed. 
- Setup scriptable objects for: 
    1. Views: This lets the controller know which view is available and lets me know immediately if I didn't add the View. 
    2. Events: This decouples script dependenices. I can receive events anywhere by adding ReceiveEvent component
    3. Buttons: There were so many buttons but with the same setup (text and image OR just image in horizontal or vertical layout). So I figured might as well setup a system I imagine this as the "backend" and the prefab as the client side. If content team wants to reorganize the order of the buttons,remove/add buttons,change button name or change button image, they can choose to do so from the scriptable object without ever affecting the client side. 

#  Your approach to the automatic pivot and to snapping, and the cases where each still gives a poor result

# What is unfinished

# The AI Tools you used
- Chatgpt
- Git Copilot 