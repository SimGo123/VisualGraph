# VisualGraph
# What is that?
With this C#-Program you can create [Graphs](https://en.wikipedia.org/wiki/Graph_(discrete_mathematics)) which consist of vertices and edges (like a rail network, a map, ...).  
You can than take a look at the adjacency matrix or execute [Dijekstra's algorithm](https://en.wikipedia.org/wiki/Dijkstra%27s_algorithm) which finds the shortest way to every other vertex which are linked by edges with the initial vertex.  
I just created this program, and if you want any changes to be done, please let me know.
# How to use the program?
If you open the program every Label will have a german text.  
To change to english, please just change the comboBox-Text to english, that's it.  
You can than add a vertex by clicking the button "Add vertex". You can than give it a name.  
Add it to the screen by just clicking at the position you want it to be.  
If you have added some vertices, you can add edges by clicking the button "Add edge".  
A dialog will appear, so you can decide from which vertex to which it goes.  
You can as well add a weight, which is for example the time it takes to go from one train station (vertex) to another.  
You can than take a look at the adjacency matrix by clicking the button "Show adjacency matrix".  
You can also save the file as a .graph-file, a file-extension which I created, and open it again.  
If you click "Execute Dijekstra" it will show you how long it takes to every other linked vertex.  
# How does the program work?
It consists of the following classes:
* Form1: Standard form with event-handlers
* Insert: Insert the vertices and edges into Dijekstra
* Dijekstra: Execute the Dijekstra-algorithm
* Vertex: Just a vertex with a name
* EdgeDialog: Insert edges
* ShowAdjacency: Show the adjacency matrix
* Results: Display the results of the Dijekstra-algorithm
* GraphInterpreter: Read and write .graph-Files
