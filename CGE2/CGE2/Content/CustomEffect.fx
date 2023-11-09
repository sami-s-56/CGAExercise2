#if OPENGL
	#define SV_POSITION POSITION
	#define VS_SHADERMODEL vs_3_0
	#define PS_SHADERMODEL ps_3_0
#else
	#define VS_SHADERMODEL vs_4_0_level_9_1
	#define PS_SHADERMODEL ps_4_0_level_9_1
#endif

sampler2D inputTexture;

float YValue;
float UValue;
float VValue;

bool bInvertColor;

// RGB to YUV conversion function
float3 RGBtoYUV(float3 color)
{
    float Y = 0.299 * color.r + 0.587 * color.g + 0.114 * color.b;
    float U = -0.147 * color.r - 0.289 * color.g + 0.436 * color.b;
    float V = 0.615 * color.r - 0.515 * color.g - 0.100 * color.b;

    return float3(Y, U, V);
}

// YUV to RGB conversion function
float3 YUVtoRGB(float3 yuv)
{
    float r = yuv.x + 1.13983 * yuv.z;
    float g = yuv.x - 0.39465 * yuv.y - 0.58060 * yuv.z;
    float b = yuv.x + 2.03211 * yuv.y;

    return float3(r, g, b);
}

float4 PS_main(float2 texCoord : TEXCOORD0) : COLOR0
{
    float4 color = tex2D(inputTexture, texCoord);

    // Convert RGB to YUV
    float3 yuv = RGBtoYUV(color.rgb);

    // Modify YUV values based on user input
    yuv.x = YValue / 200.0;
    yuv.y = UValue / 200.0;
    yuv.z = VValue / 200.0;

    // Invert Colors if necessary
    bool invertColors = false; // Set this value based on the checkbox
    if (invertColors)
    {
        yuv.x = 1.0 - YValue;
        yuv.y = 1.0 - UValue;
        yuv.z = 1.0 - VValue;
    }
    
    // Convert YUV back to RGB
    float3 rgb = YUVtoRGB(yuv);

    return float4(rgb, color.a);
}