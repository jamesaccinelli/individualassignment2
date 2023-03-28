# Individual Assignment 2

Water, Ship Textures originate from: https://3dtextures.me/ <br>
"Shark" and "Mountain" Textures were created by myself via photoshop. <br>
<br>
<br>
Difference Between Forward and Deferred Rendering: <br>
Forward Rendering renders each light as a seperate pass (2 lights on an object = 2 passes). This allows the light to accumulate on the object. Forward Rendering is also very linear, in the sense that each case of geometry again has a seperate pass one at a time to produce the final image. <br>
<br>
Deferred Rendering adds each light as one single pass by _deferring_ all of the geomerty until they are all passed through. The shading is applied at the very end to produce the final image. This allows us to have as many lights we want on an object, as well as shadows. This techinque is also much more efficient for performance. <br>
<br>

__
