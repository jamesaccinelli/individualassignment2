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
<br>
Toon Shaded Square Wave: <br>
I implemented the wave shader basing off of the wave shader provided during the lectures. For this assignment, I built upon it by adding/modifiying a few different things. Firstly as the assignment required, I was able to implement both toon shading as well as the square waveform into the shader. Alongside this, I was also able to add both normal mapping and scrolling/foam to make the water texturing more realistic. You can see screenshots of the shader above for a more in-depth look, however I will give a brief rundown here. The square wave was implemented by simply normalizing the initial sign wave. This places constraints onto the waveheight, allowing us to create a maximum to minimum effect very easily. As for the toon shading, I implented this by adding toonramp into the pragma along side the vertex:vert that was there initially. I then added the base toonshading code as provided from our lectures. This same idea was used for both the normalmapping and the foam. The intial code I believe is unchanged for each technique, however they are simply all combined together into one shader. <br>
<br>
Example Code 1: <br>
The following code details the script for a blurring effect to place on the camera. This script pairs with a shader to be able to adjust the amount of blurring in a scene. The script utilizes both downsampling and upsampling to enhance the blurring effect. This sort of technique could be used in many different ways, such as a scene transition similar to older Mario games, or during a cutscene while the character is waking up or previously unconscious. See the highlighted code in the drive link. <br>
<br>
Outling + Shadow: <br>
For this section of the assignment, I decided to implement both outling and custom shadows into the scene. I added outlining to the ship, to make it stand out a little more, and I added shadow to the grass area to make it more defined. For the outlining, I built off of the initial outlining shader made in-class, and then added normal mapping to it, so that I could add texture for realism. The same can be said for the shadows. I built-off the in-class example, then added colour and normal mapping to it to make a more realisitic grass effect. <br>
<br>
The outlining shader utilizes two passes to seperate the calculations. The first pass is where the outline colour is calculated and then applied, whereas the second is where the rest of the lighting effects are applied. The shadow shader uses the same 2 pass process, calculating the lighting initially, then finalizing the shadows in the second pass. <br>
<br>
Example Code 2: <br>
The following code details how to create a custom shadow colour casted by an object. This shader could perhaps be used in a scene/game which has unrealistic light sources, and requires different coloured shadows to help further represent this. See drive link for highlighted code. <br>
<br>
Additional Shader -> Shadow Lines <br>
For this section of the assignment, I elected to add shadow lines to the rock/mountain area of the scene. I chose to do this to add a more cartoony theme present in the scene. As for the shader itself, it consists of 2 passes, one to seperate the shadow casting (Pass 2), and one for creating the shadow lines as well as handling other properties like textures. The shader utilizes a vertex and fragment shader in both passes. We then tell unity to ignore lightmaps, so that we can create our own shadows. In our appdata we have standard values such as position, normal, and uv coordinates. In our v2f, we have our uv coordinates, colour, position, and shadow coordinates. In our vertex shader we calculate our shadow. We do so by converting the normal to world space, then converting it to something the fragment shader can use. In our fragment shader, we use the SHADOW_ATTENUATION boolean value to whether an object will recieve the main object's shadows or not (if the lines appear on it or not). Our shadow colour is equal to our shadow texture, our shadow lines, multiplied by our linesZoom property, adjusting how far apart our lines are. We then assign our shadow, col, and shadow colour values into our finalColour value by lerping them together. We then return finalColour. In our second pass, we use shadowcaster, telling unity we are casting our own shadows. We then pass our shadowcaster values from our v2f to our vertex shade, and then through to our fragment shader. -> A copy of the flowchart for this shader is included inthe drive link above. <br>

