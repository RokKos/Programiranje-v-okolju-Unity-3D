Shader "DT\Basic\SimpleShader"{
	SubSHader{
		Tags = {"RenderType" = Opaque}
		CGPROGRAM
		#pragma surface surf Lambert
		struct Input{
			//(1.0, 1.0, 1.0, 1.0) R, G, B, A
			float4 color : COLOR; 
		};
		void surf(Input IN, inout SurfaceOutput o){
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "Diffuse"
}