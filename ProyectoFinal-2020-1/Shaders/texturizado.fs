#version 330 core

in vec2 out_uv;
out vec4 color; 
uniform sampler2D ourTexture;  // unidad de textura sampler2D

void main(){
	
//Obtiene el color de la textura en base a la unidad de textura
	color = texture(ourTexture, out_uv);
	//color = vec4(0.3, 0.5, 0.4, 1.0);
}