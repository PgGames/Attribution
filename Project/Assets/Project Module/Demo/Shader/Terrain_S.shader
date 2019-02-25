// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:9361,x:34210,y:32536,varname:node_9361,prsc:2|custl-5915-OUT,clip-6438-OUT,voffset-3468-OUT,tess-9811-OUT;n:type:ShaderForge.SFN_Tex2d,id:1472,x:32581,y:32957,ptovrint:False,ptlb:Vertex_Tex_Main,ptin:_Vertex_Tex_Main,varname:node_1472,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-6312-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:6312,x:31592,y:32830,varname:node_6312,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_NormalVector,id:3405,x:32970,y:33229,prsc:2,pt:False;n:type:ShaderForge.SFN_Multiply,id:6600,x:33362,y:33069,varname:node_6600,prsc:2|A-5539-OUT,B-3405-OUT;n:type:ShaderForge.SFN_Multiply,id:3468,x:33691,y:33025,varname:node_3468,prsc:2|A-6600-OUT,B-2266-OUT;n:type:ShaderForge.SFN_Slider,id:2266,x:33155,y:33358,ptovrint:False,ptlb:VertexOffset,ptin:_VertexOffset,varname:node_2266,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:2;n:type:ShaderForge.SFN_ValueProperty,id:9811,x:34016,y:33176,ptovrint:False,ptlb:Smooth,ptin:_Smooth,varname:node_9811,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:4;n:type:ShaderForge.SFN_Color,id:6694,x:33488,y:32287,ptovrint:False,ptlb:Aldebo_C,ptin:_Aldebo_C,varname:node_6694,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_LightVector,id:6455,x:32868,y:32158,varname:node_6455,prsc:2;n:type:ShaderForge.SFN_LightColor,id:7118,x:33253,y:32595,varname:node_7118,prsc:2;n:type:ShaderForge.SFN_LightAttenuation,id:6446,x:33067,y:32515,varname:node_6446,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:712,x:32879,y:32367,prsc:2,pt:False;n:type:ShaderForge.SFN_Multiply,id:3618,x:33253,y:32362,varname:node_3618,prsc:2|A-3427-OUT,B-6446-OUT;n:type:ShaderForge.SFN_Dot,id:3427,x:33106,y:32306,varname:node_3427,prsc:2,dt:0|A-6455-OUT,B-712-OUT;n:type:ShaderForge.SFN_Multiply,id:969,x:33726,y:32526,varname:node_969,prsc:2|A-3618-OUT,B-7118-RGB;n:type:ShaderForge.SFN_Tex2d,id:8422,x:33488,y:32080,ptovrint:False,ptlb:Aldebo_Tex,ptin:_Aldebo_Tex,varname:node_8422,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:5915,x:33955,y:32442,varname:node_5915,prsc:2|A-8422-RGB,B-6694-RGB,C-969-OUT;n:type:ShaderForge.SFN_Noise,id:5976,x:32582,y:32590,varname:node_5976,prsc:2|XY-1879-UVOUT;n:type:ShaderForge.SFN_UVTile,id:1879,x:32353,y:32590,varname:node_1879,prsc:2|UVIN-6312-UVOUT,WDT-7082-X,HGT-7082-Y,TILE-8866-OUT;n:type:ShaderForge.SFN_Vector4Property,id:7082,x:32032,y:32576,ptovrint:False,ptlb:Min_Vertex_Re,ptin:_Min_Vertex_Re,varname:node_7082,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2,v2:2,v3:0,v4:0;n:type:ShaderForge.SFN_Slider,id:8866,x:32242,y:32800,ptovrint:False,ptlb:Min_Vertext_Tile,ptin:_Min_Vertext_Tile,varname:node_8866,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3460485,max:1;n:type:ShaderForge.SFN_Multiply,id:2833,x:32813,y:32604,varname:node_2833,prsc:2|A-3757-OUT,B-5976-OUT;n:type:ShaderForge.SFN_Slider,id:3757,x:32553,y:32496,ptovrint:False,ptlb:Min_Vertex,ptin:_Min_Vertex,varname:node_3757,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:0.1;n:type:ShaderForge.SFN_Add,id:9915,x:33139,y:32750,varname:node_9915,prsc:2|A-2833-OUT,B-1171-OUT;n:type:ShaderForge.SFN_Tex2d,id:5042,x:33681,y:32742,ptovrint:False,ptlb:Opacity,ptin:_Opacity,varname:node_5042,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Desaturate,id:6438,x:33865,y:32742,varname:node_6438,prsc:2|COL-5042-RGB;n:type:ShaderForge.SFN_Tex2d,id:1033,x:32779,y:33186,ptovrint:False,ptlb:Vertex_Tex2,ptin:_Vertex_Tex2,varname:node_1033,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:5539,x:33230,y:32921,varname:node_5539,prsc:2|A-9915-OUT,B-1033-RGB;n:type:ShaderForge.SFN_Desaturate,id:1171,x:32826,y:32871,varname:node_1171,prsc:2|COL-1472-RGB;proporder:8422-6694-1472-1033-2266-9811-7082-8866-3757-5042;pass:END;sub:END;*/

Shader "Shader Forge/Terrain_S" {
    Properties {
        _Aldebo_Tex ("Aldebo_Tex", 2D) = "white" {}
        _Aldebo_C ("Aldebo_C", Color) = (0.5,0.5,0.5,1)
        _Vertex_Tex_Main ("Vertex_Tex_Main", 2D) = "white" {}
        _Vertex_Tex2 ("Vertex_Tex2", 2D) = "white" {}
        _VertexOffset ("VertexOffset", Range(0, 2)) = 0
        _Smooth ("Smooth", Float ) = 4
        _Min_Vertex_Re ("Min_Vertex_Re", Vector) = (2,2,0,0)
        _Min_Vertext_Tile ("Min_Vertext_Tile", Range(0, 1)) = 0.3460485
        _Min_Vertex ("Min_Vertex", Range(0, 0.1)) = 0
        _Opacity ("Opacity", 2D) = "white" {}
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D _Vertex_Tex_Main; uniform float4 _Vertex_Tex_Main_ST;
            uniform float _VertexOffset;
            uniform float _Smooth;
            uniform float4 _Aldebo_C;
            uniform sampler2D _Aldebo_Tex; uniform float4 _Aldebo_Tex_ST;
            uniform float4 _Min_Vertex_Re;
            uniform float _Min_Vertext_Tile;
            uniform float _Min_Vertex;
            uniform sampler2D _Opacity; uniform float4 _Opacity_ST;
            uniform sampler2D _Vertex_Tex2; uniform float4 _Vertex_Tex2_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float2 node_1879_tc_rcp = float2(1.0,1.0)/float2( _Min_Vertex_Re.r, _Min_Vertex_Re.g );
                float node_1879_ty = floor(_Min_Vertext_Tile * node_1879_tc_rcp.x);
                float node_1879_tx = _Min_Vertext_Tile - _Min_Vertex_Re.r * node_1879_ty;
                float2 node_1879 = (o.uv0 + float2(node_1879_tx, node_1879_ty)) * node_1879_tc_rcp;
                float2 node_5976_skew = node_1879 + 0.2127+node_1879.x*0.3713*node_1879.y;
                float2 node_5976_rnd = 4.789*sin(489.123*(node_5976_skew));
                float node_5976 = frac(node_5976_rnd.x*node_5976_rnd.y*(1+node_5976_skew.x));
                float4 _Vertex_Tex_Main_var = tex2Dlod(_Vertex_Tex_Main,float4(TRANSFORM_TEX(o.uv0, _Vertex_Tex_Main),0.0,0));
                float4 _Vertex_Tex2_var = tex2Dlod(_Vertex_Tex2,float4(TRANSFORM_TEX(o.uv0, _Vertex_Tex2),0.0,0));
                v.vertex.xyz += (((((_Min_Vertex*node_5976)+dot(_Vertex_Tex_Main_var.rgb,float3(0.3,0.59,0.11)))*_Vertex_Tex2_var.rgb)*v.normal)*_VertexOffset);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Smooth;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float4 _Opacity_var = tex2D(_Opacity,TRANSFORM_TEX(i.uv0, _Opacity));
                clip(dot(_Opacity_var.rgb,float3(0.3,0.59,0.11)) - 0.5);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _Aldebo_Tex_var = tex2D(_Aldebo_Tex,TRANSFORM_TEX(i.uv0, _Aldebo_Tex));
                float3 finalColor = (_Aldebo_Tex_var.rgb*_Aldebo_C.rgb*((dot(lightDirection,i.normalDir)*attenuation)*_LightColor0.rgb));
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #pragma multi_compile_fwdadd_fullshadows
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D _Vertex_Tex_Main; uniform float4 _Vertex_Tex_Main_ST;
            uniform float _VertexOffset;
            uniform float _Smooth;
            uniform float4 _Aldebo_C;
            uniform sampler2D _Aldebo_Tex; uniform float4 _Aldebo_Tex_ST;
            uniform float4 _Min_Vertex_Re;
            uniform float _Min_Vertext_Tile;
            uniform float _Min_Vertex;
            uniform sampler2D _Opacity; uniform float4 _Opacity_ST;
            uniform sampler2D _Vertex_Tex2; uniform float4 _Vertex_Tex2_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                LIGHTING_COORDS(3,4)
                UNITY_FOG_COORDS(5)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float2 node_1879_tc_rcp = float2(1.0,1.0)/float2( _Min_Vertex_Re.r, _Min_Vertex_Re.g );
                float node_1879_ty = floor(_Min_Vertext_Tile * node_1879_tc_rcp.x);
                float node_1879_tx = _Min_Vertext_Tile - _Min_Vertex_Re.r * node_1879_ty;
                float2 node_1879 = (o.uv0 + float2(node_1879_tx, node_1879_ty)) * node_1879_tc_rcp;
                float2 node_5976_skew = node_1879 + 0.2127+node_1879.x*0.3713*node_1879.y;
                float2 node_5976_rnd = 4.789*sin(489.123*(node_5976_skew));
                float node_5976 = frac(node_5976_rnd.x*node_5976_rnd.y*(1+node_5976_skew.x));
                float4 _Vertex_Tex_Main_var = tex2Dlod(_Vertex_Tex_Main,float4(TRANSFORM_TEX(o.uv0, _Vertex_Tex_Main),0.0,0));
                float4 _Vertex_Tex2_var = tex2Dlod(_Vertex_Tex2,float4(TRANSFORM_TEX(o.uv0, _Vertex_Tex2),0.0,0));
                v.vertex.xyz += (((((_Min_Vertex*node_5976)+dot(_Vertex_Tex_Main_var.rgb,float3(0.3,0.59,0.11)))*_Vertex_Tex2_var.rgb)*v.normal)*_VertexOffset);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Smooth;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float4 _Opacity_var = tex2D(_Opacity,TRANSFORM_TEX(i.uv0, _Opacity));
                clip(dot(_Opacity_var.rgb,float3(0.3,0.59,0.11)) - 0.5);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float4 _Aldebo_Tex_var = tex2D(_Aldebo_Tex,TRANSFORM_TEX(i.uv0, _Aldebo_Tex));
                float3 finalColor = (_Aldebo_Tex_var.rgb*_Aldebo_C.rgb*((dot(lightDirection,i.normalDir)*attenuation)*_LightColor0.rgb));
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D _Vertex_Tex_Main; uniform float4 _Vertex_Tex_Main_ST;
            uniform float _VertexOffset;
            uniform float _Smooth;
            uniform float4 _Min_Vertex_Re;
            uniform float _Min_Vertext_Tile;
            uniform float _Min_Vertex;
            uniform sampler2D _Opacity; uniform float4 _Opacity_ST;
            uniform sampler2D _Vertex_Tex2; uniform float4 _Vertex_Tex2_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float2 node_1879_tc_rcp = float2(1.0,1.0)/float2( _Min_Vertex_Re.r, _Min_Vertex_Re.g );
                float node_1879_ty = floor(_Min_Vertext_Tile * node_1879_tc_rcp.x);
                float node_1879_tx = _Min_Vertext_Tile - _Min_Vertex_Re.r * node_1879_ty;
                float2 node_1879 = (o.uv0 + float2(node_1879_tx, node_1879_ty)) * node_1879_tc_rcp;
                float2 node_5976_skew = node_1879 + 0.2127+node_1879.x*0.3713*node_1879.y;
                float2 node_5976_rnd = 4.789*sin(489.123*(node_5976_skew));
                float node_5976 = frac(node_5976_rnd.x*node_5976_rnd.y*(1+node_5976_skew.x));
                float4 _Vertex_Tex_Main_var = tex2Dlod(_Vertex_Tex_Main,float4(TRANSFORM_TEX(o.uv0, _Vertex_Tex_Main),0.0,0));
                float4 _Vertex_Tex2_var = tex2Dlod(_Vertex_Tex2,float4(TRANSFORM_TEX(o.uv0, _Vertex_Tex2),0.0,0));
                v.vertex.xyz += (((((_Min_Vertex*node_5976)+dot(_Vertex_Tex_Main_var.rgb,float3(0.3,0.59,0.11)))*_Vertex_Tex2_var.rgb)*v.normal)*_VertexOffset);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Smooth;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 normalDirection = i.normalDir;
                float4 _Opacity_var = tex2D(_Opacity,TRANSFORM_TEX(i.uv0, _Opacity));
                clip(dot(_Opacity_var.rgb,float3(0.3,0.59,0.11)) - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
