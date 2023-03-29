# Individual Assignment 2

Water, Ship Textures originate from: https://3dtextures.me/ <br>
"Shark" and "Mountain" Textures were created by myself via photoshop prior to assignment. <br>
Images including diagrams, screenshots, etc: https://drive.google.com/drive/folders/1-juTw9Q-8qpoJ8ifxZZWMoEaGvq54Ig8?usp=share_link (I could not figure out how to add images directly to GitHub) <br>
<br>
<br>
Difference Between Forward and Deferred Rendering: <br>
Forward Rendering renders each light as a seperate pass (2 lights on an object = 2 passes). This allows the light to accumulate on the object. Forward Rendering is also very linear, in the sense that each case of geometry again has a seperate pass one at a time to produce the final image. <br>
<br>
Deferred Rendering adds each light as one single pass by _deferring_ all of the geomerty until they are all passed through. The shading is applied at the very end to produce the final image. This allows us to have as many lights we want on an object, as well as shadows. This techinque is also much more efficient for performance. <br>
<br>
As seen in the diagrams, deferred rendering allows us to add lighting much easier and more efficiently. Due in part to it taking place in one pass, the advantages over deferred rendering are much more preferable. <br>
<br>
This can be used in a scene with many different light sources affecting the objects in the scene. This can be done in a way as such: <br>
<br>
Example Psuedocode/Flowchart: "Deferred Rendering" <br>
Properties -> whatever properties you might be using <br>
CG/Pass -> Light Mode = Deferred <br>
appdata -> all our variables and values such as normals and position <br>
v2f -> taking info from our appdata <br>
vertex function -> taking data from v2f and performing various calculations such as transforming our object to clip space <br>
frag function -> calculating final lighting <br>
ENDCG <br>

