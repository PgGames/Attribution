// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:1,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:33858,y:32857,varname:node_2865,prsc:2|diff-6343-OUT,spec-8306-OUT,gloss-3938-OUT,normal-5964-RGB,emission-2461-OUT,alpha-7588-A,voffset-4517-OUT,tess-8575-OUT;n:type:ShaderForge.SFN_Multiply,id:6343,x:32920,y:32560,varname:node_6343,prsc:2|A-6665-RGB,B-7588-RGB,C-7588-A;n:type:ShaderForge.SFN_Color,id:6665,x:32628,y:32394,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5019608,c2:0.5019608,c3:0.5019608,c4:1;n:type:ShaderForge.SFN_Tex2d,id:5964,x:33271,y:32944,ptovrint:True,ptlb:Normal Map,ptin:_BumpMap,varname:_BumpMap,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_Slider,id:358,x:33536,y:31727,ptovrint:False,ptlb:Metallic,ptin:_Metallic,varname:node_358,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5816421,max:1;n:type:ShaderForge.SFN_Slider,id:1813,x:33572,y:32082,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:_Metallic_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.417301,max:1;n:type:ShaderForge.SFN_Tex2d,id:7588,x:32573,y:32617,ptovrint:False,ptlb:Base Color,ptin:_BaseColor,varname:node_7588,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:accfa9c068e62fc48bf45378b0ad38a1,ntxv:0,isnm:False|UVIN-5606-OUT;n:type:ShaderForge.SFN_TexCoord,id:5032,x:31232,y:32366,varname:node_5032,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Append,id:5606,x:32300,y:32386,varname:node_5606,prsc:2|A-8893-R,B-3712-OUT;n:type:ShaderForge.SFN_Power,id:7772,x:31855,y:32531,varname:node_7772,prsc:2|VAL-8893-G,EXP-3524-OUT;n:type:ShaderForge.SFN_Rotator,id:8173,x:31483,y:32348,varname:node_8173,prsc:2|UVIN-5032-UVOUT,ANG-1721-OUT;n:type:ShaderForge.SFN_Slider,id:4167,x:30980,y:32562,ptovrint:False,ptlb:Ang,ptin:_Ang,varname:node_4167,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:2;n:type:ShaderForge.SFN_Multiply,id:1721,x:31463,y:32629,varname:node_1721,prsc:2|A-4167-OUT,B-9746-OUT;n:type:ShaderForge.SFN_Pi,id:9746,x:31244,y:32648,varname:node_9746,prsc:2;n:type:ShaderForge.SFN_Slider,id:9021,x:31265,y:32831,ptovrint:False,ptlb:Scale,ptin:_Scale,varname:node_9021,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:1,cur:2,max:2;n:type:ShaderForge.SFN_RemapRange,id:3524,x:31596,y:32799,varname:node_3524,prsc:2,frmn:1,frmx:2,tomn:50,tomx:1|IN-9021-OUT;n:type:ShaderForge.SFN_Tex2d,id:7209,x:33186,y:33250,ptovrint:False,ptlb:VertexOff_Tex,ptin:_VertexOff_Tex,varname:node_7209,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:abf64b709c2156e48b51c7c2a69be972,ntxv:0,isnm:False|UVIN-6152-UVOUT;n:type:ShaderForge.SFN_Multiply,id:4517,x:33355,y:33473,varname:node_4517,prsc:2|A-7209-RGB,B-3569-OUT,C-5468-OUT;n:type:ShaderForge.SFN_NormalVector,id:3569,x:33094,y:33513,prsc:2,pt:False;n:type:ShaderForge.SFN_ValueProperty,id:8575,x:33771,y:33383,ptovrint:False,ptlb:Smooth,ptin:_Smooth,varname:node_8575,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2;n:type:ShaderForge.SFN_Slider,id:5468,x:32996,y:33740,ptovrint:False,ptlb:VertexOff_St,ptin:_VertexOff_St,varname:node_5468,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Tex2d,id:5867,x:33651,y:31516,ptovrint:False,ptlb:Metallic_Tex,ptin:_Metallic_Tex,varname:node_5867,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:2108,x:33927,y:31657,varname:node_2108,prsc:2|A-5867-R,B-5867-G,C-5867-B,D-358-OUT;n:type:ShaderForge.SFN_Tex2d,id:409,x:33634,y:31848,ptovrint:False,ptlb:Roughness_Tex,ptin:_Roughness_Tex,varname:node_409,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Desaturate,id:6996,x:33805,y:31905,varname:node_6996,prsc:2|COL-409-RGB;n:type:ShaderForge.SFN_Multiply,id:602,x:33988,y:31937,varname:node_602,prsc:2|A-6996-OUT,B-1813-OUT;n:type:ShaderForge.SFN_Set,id:1319,x:34180,y:31960,varname:Roughness,prsc:2|IN-602-OUT;n:type:ShaderForge.SFN_Get,id:3938,x:33458,y:32899,varname:node_3938,prsc:2|IN-1319-OUT;n:type:ShaderForge.SFN_Set,id:2808,x:34120,y:31673,varname:Metallic,prsc:2|IN-2108-OUT;n:type:ShaderForge.SFN_Get,id:8306,x:33423,y:32838,varname:node_8306,prsc:2|IN-2808-OUT;n:type:ShaderForge.SFN_Tex2d,id:7192,x:33615,y:32363,ptovrint:False,ptlb:Emission,ptin:_Emission,varname:node_7192,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:5,x:33958,y:32259,varname:node_5,prsc:2|A-7452-RGB,B-7192-RGB,C-8294-OUT;n:type:ShaderForge.SFN_Slider,id:8294,x:33551,y:32568,ptovrint:False,ptlb:Emission_st,ptin:_Emission_st,varname:node_8294,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Color,id:7452,x:33615,y:32184,ptovrint:False,ptlb:Emission_C,ptin:_Emission_C,varname:node_7452,prsc:2,glob:False,taghide:False,taghdr:True,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Set,id:2632,x:34175,y:32259,varname:Emission,prsc:2|IN-5-OUT;n:type:ShaderForge.SFN_Get,id:2461,x:33423,y:33050,varname:node_2461,prsc:2|IN-2632-OUT;n:type:ShaderForge.SFN_TexCoord,id:1254,x:32070,y:33155,varname:node_1254,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_UVTile,id:6152,x:32918,y:33223,varname:node_6152,prsc:2|UVIN-8197-OUT,WDT-8059-X,HGT-8059-Y,TILE-7884-OUT;n:type:ShaderForge.SFN_Vector4Property,id:8059,x:31745,y:33309,ptovrint:False,ptlb:Multiple,ptin:_Multiple,varname:node_8059,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:2,v2:2,v3:0,v4:0;n:type:ShaderForge.SFN_Vector1,id:7884,x:32841,y:33446,varname:node_7884,prsc:2,v1:0;n:type:ShaderForge.SFN_Add,id:6735,x:32342,y:33107,varname:node_6735,prsc:2|A-8124-OUT,B-1254-U;n:type:ShaderForge.SFN_Slider,id:7576,x:31784,y:33045,ptovrint:False,ptlb:Vertex_X,ptin:_Vertex_X,varname:node_7576,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Add,id:2480,x:32370,y:33353,varname:node_2480,prsc:2|A-1254-V,B-6881-OUT;n:type:ShaderForge.SFN_Slider,id:2755,x:31787,y:33604,ptovrint:False,ptlb:Vertex_Y,ptin:_Vertex_Y,varname:node_2755,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7000878,max:1;n:type:ShaderForge.SFN_Append,id:8197,x:32625,y:33131,varname:node_8197,prsc:2|A-6735-OUT,B-2480-OUT;n:type:ShaderForge.SFN_Power,id:3712,x:32116,y:32588,varname:node_3712,prsc:2|VAL-7772-OUT,EXP-3524-OUT;n:type:ShaderForge.SFN_ComponentMask,id:8893,x:31634,y:32348,varname:node_8893,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-8173-UVOUT;n:type:ShaderForge.SFN_Multiply,id:8124,x:32192,y:32928,varname:node_8124,prsc:2|A-8059-X,B-7576-OUT;n:type:ShaderForge.SFN_Multiply,id:6881,x:32264,y:33576,varname:node_6881,prsc:2|A-2755-OUT,B-8059-Y;proporder:7588-6665-9021-4167-5867-358-409-1813-5964-7192-7452-8294-7209-5468-8575-8059-7576-2755;pass:END;sub:END;*/

Shader "Shader Forge/Texture_Animation" {
    Properties {
        _BaseColor ("Base Color", 2D) = "white" {}
        _Color ("Color", Color) = (0.5019608,0.5019608,0.5019608,1)
        _Scale ("Scale", Range(1, 2)) = 2
        _Ang ("Ang", Range(0, 2)) = 2
        _Metallic_Tex ("Metallic_Tex", 2D) = "white" {}
        _Metallic ("Metallic", Range(0, 1)) = 0.5816421
        _Roughness_Tex ("Roughness_Tex", 2D) = "white" {}
        _Gloss ("Gloss", Range(0, 1)) = 0.417301
        _BumpMap ("Normal Map", 2D) = "bump" {}
        _Emission ("Emission", 2D) = "white" {}
        [HDR]_Emission_C ("Emission_C", Color) = (1,1,1,1)
        _Emission_st ("Emission_st", Range(0, 1)) = 0
        _VertexOff_Tex ("VertexOff_Tex", 2D) = "white" {}
        _VertexOff_St ("VertexOff_St", Range(0, 1)) = 0
        _Smooth ("Smooth", Float ) = 2
        _Multiple ("Multiple", Vector) = (2,2,0,0)
        _Vertex_X ("Vertex_X", Range(0, 1)) = 1
        _Vertex_Y ("Vertex_Y", Range(0, 1)) = 0.7000878
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform float4 _Color;
            uniform sampler2D _BumpMap; uniform float4 _BumpMap_ST;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform sampler2D _BaseColor; uniform float4 _BaseColor_ST;
            uniform float _Ang;
            uniform float _Scale;
            uniform sampler2D _VertexOff_Tex; uniform float4 _VertexOff_Tex_ST;
            uniform float _Smooth;
            uniform float _VertexOff_St;
            uniform sampler2D _Metallic_Tex; uniform float4 _Metallic_Tex_ST;
            uniform sampler2D _Roughness_Tex; uniform float4 _Roughness_Tex_ST;
            uniform sampler2D _Emission; uniform float4 _Emission_ST;
            uniform float _Emission_st;
            uniform float4 _Emission_C;
            uniform float4 _Multiple;
            uniform float _Vertex_X;
            uniform float _Vertex_Y;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                UNITY_FOG_COORDS(7)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD8;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float node_7884 = 0.0;
                float2 node_6152_tc_rcp = float2(1.0,1.0)/float2( _Multiple.r, _Multiple.g );
                float node_6152_ty = floor(node_7884 * node_6152_tc_rcp.x);
                float node_6152_tx = node_7884 - _Multiple.r * node_6152_ty;
                float2 node_6152 = (float2(((_Multiple.r*_Vertex_X)+o.uv0.r),(o.uv0.g+(_Vertex_Y*_Multiple.g))) + float2(node_6152_tx, node_6152_ty)) * node_6152_tc_rcp;
                float4 _VertexOff_Tex_var = tex2Dlod(_VertexOff_Tex,float4(TRANSFORM_TEX(node_6152, _VertexOff_Tex),0.0,0));
                v.vertex.xyz += (_VertexOff_Tex_var.rgb*v.normal*_VertexOff_St);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
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
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
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
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _BumpMap_var = UnpackNormal(tex2D(_BumpMap,TRANSFORM_TEX(i.uv0, _BumpMap)));
                float3 normalLocal = _BumpMap_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _Roughness_Tex_var = tex2D(_Roughness_Tex,TRANSFORM_TEX(i.uv0, _Roughness_Tex));
                float Roughness = (dot(_Roughness_Tex_var.rgb,float3(0.3,0.59,0.11))*_Gloss);
                float gloss = 1.0 - Roughness; // Convert roughness to gloss
                float perceptualRoughness = Roughness;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float4 _Metallic_Tex_var = tex2D(_Metallic_Tex,TRANSFORM_TEX(i.uv0, _Metallic_Tex));
                float Metallic = (_Metallic_Tex_var.r*_Metallic_Tex_var.g*_Metallic_Tex_var.b*_Metallic);
                float3 specularColor = Metallic;
                float specularMonochrome;
                float node_8173_ang = (_Ang*3.141592654);
                float node_8173_spd = 1.0;
                float node_8173_cos = cos(node_8173_spd*node_8173_ang);
                float node_8173_sin = sin(node_8173_spd*node_8173_ang);
                float2 node_8173_piv = float2(0.5,0.5);
                float2 node_8173 = (mul(i.uv0-node_8173_piv,float2x2( node_8173_cos, -node_8173_sin, node_8173_sin, node_8173_cos))+node_8173_piv);
                float2 node_8893 = node_8173.rg;
                float node_3524 = (_Scale*-49.0+99.0);
                float2 node_5606 = float2(node_8893.r,pow(pow(node_8893.g,node_3524),node_3524));
                float4 _BaseColor_var = tex2D(_BaseColor,TRANSFORM_TEX(node_5606, _BaseColor));
                float3 diffuseColor = (_Color.rgb*_BaseColor_var.rgb*_BaseColor_var.a); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float4 _Emission_var = tex2D(_Emission,TRANSFORM_TEX(i.uv0, _Emission));
                float3 Emission = (_Emission_C.rgb*_Emission_var.rgb*_Emission_st);
                float3 emissive = Emission;
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(finalColor,_BaseColor_var.a);
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
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform float4 _Color;
            uniform sampler2D _BumpMap; uniform float4 _BumpMap_ST;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform sampler2D _BaseColor; uniform float4 _BaseColor_ST;
            uniform float _Ang;
            uniform float _Scale;
            uniform sampler2D _VertexOff_Tex; uniform float4 _VertexOff_Tex_ST;
            uniform float _Smooth;
            uniform float _VertexOff_St;
            uniform sampler2D _Metallic_Tex; uniform float4 _Metallic_Tex_ST;
            uniform sampler2D _Roughness_Tex; uniform float4 _Roughness_Tex_ST;
            uniform sampler2D _Emission; uniform float4 _Emission_ST;
            uniform float _Emission_st;
            uniform float4 _Emission_C;
            uniform float4 _Multiple;
            uniform float _Vertex_X;
            uniform float _Vertex_Y;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                LIGHTING_COORDS(7,8)
                UNITY_FOG_COORDS(9)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float node_7884 = 0.0;
                float2 node_6152_tc_rcp = float2(1.0,1.0)/float2( _Multiple.r, _Multiple.g );
                float node_6152_ty = floor(node_7884 * node_6152_tc_rcp.x);
                float node_6152_tx = node_7884 - _Multiple.r * node_6152_ty;
                float2 node_6152 = (float2(((_Multiple.r*_Vertex_X)+o.uv0.r),(o.uv0.g+(_Vertex_Y*_Multiple.g))) + float2(node_6152_tx, node_6152_ty)) * node_6152_tc_rcp;
                float4 _VertexOff_Tex_var = tex2Dlod(_VertexOff_Tex,float4(TRANSFORM_TEX(node_6152, _VertexOff_Tex),0.0,0));
                v.vertex.xyz += (_VertexOff_Tex_var.rgb*v.normal*_VertexOff_St);
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
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
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
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
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
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _BumpMap_var = UnpackNormal(tex2D(_BumpMap,TRANSFORM_TEX(i.uv0, _BumpMap)));
                float3 normalLocal = _BumpMap_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float4 _Roughness_Tex_var = tex2D(_Roughness_Tex,TRANSFORM_TEX(i.uv0, _Roughness_Tex));
                float Roughness = (dot(_Roughness_Tex_var.rgb,float3(0.3,0.59,0.11))*_Gloss);
                float gloss = 1.0 - Roughness; // Convert roughness to gloss
                float perceptualRoughness = Roughness;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float4 _Metallic_Tex_var = tex2D(_Metallic_Tex,TRANSFORM_TEX(i.uv0, _Metallic_Tex));
                float Metallic = (_Metallic_Tex_var.r*_Metallic_Tex_var.g*_Metallic_Tex_var.b*_Metallic);
                float3 specularColor = Metallic;
                float specularMonochrome;
                float node_8173_ang = (_Ang*3.141592654);
                float node_8173_spd = 1.0;
                float node_8173_cos = cos(node_8173_spd*node_8173_ang);
                float node_8173_sin = sin(node_8173_spd*node_8173_ang);
                float2 node_8173_piv = float2(0.5,0.5);
                float2 node_8173 = (mul(i.uv0-node_8173_piv,float2x2( node_8173_cos, -node_8173_sin, node_8173_sin, node_8173_cos))+node_8173_piv);
                float2 node_8893 = node_8173.rg;
                float node_3524 = (_Scale*-49.0+99.0);
                float2 node_5606 = float2(node_8893.r,pow(pow(node_8893.g,node_3524),node_3524));
                float4 _BaseColor_var = tex2D(_BaseColor,TRANSFORM_TEX(node_5606, _BaseColor));
                float3 diffuseColor = (_Color.rgb*_BaseColor_var.rgb*_BaseColor_var.a); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * _BaseColor_var.a,0);
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
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D _VertexOff_Tex; uniform float4 _VertexOff_Tex_ST;
            uniform float _Smooth;
            uniform float _VertexOff_St;
            uniform float4 _Multiple;
            uniform float _Vertex_X;
            uniform float _Vertex_Y;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float2 uv1 : TEXCOORD2;
                float2 uv2 : TEXCOORD3;
                float4 posWorld : TEXCOORD4;
                float3 normalDir : TEXCOORD5;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float node_7884 = 0.0;
                float2 node_6152_tc_rcp = float2(1.0,1.0)/float2( _Multiple.r, _Multiple.g );
                float node_6152_ty = floor(node_7884 * node_6152_tc_rcp.x);
                float node_6152_tx = node_7884 - _Multiple.r * node_6152_ty;
                float2 node_6152 = (float2(((_Multiple.r*_Vertex_X)+o.uv0.r),(o.uv0.g+(_Vertex_Y*_Multiple.g))) + float2(node_6152_tx, node_6152_ty)) * node_6152_tc_rcp;
                float4 _VertexOff_Tex_var = tex2Dlod(_VertexOff_Tex,float4(TRANSFORM_TEX(node_6152, _VertexOff_Tex),0.0,0));
                v.vertex.xyz += (_VertexOff_Tex_var.rgb*v.normal*_VertexOff_St);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
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
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
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
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
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
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform float4 _Color;
            uniform float _Metallic;
            uniform float _Gloss;
            uniform sampler2D _BaseColor; uniform float4 _BaseColor_ST;
            uniform float _Ang;
            uniform float _Scale;
            uniform sampler2D _VertexOff_Tex; uniform float4 _VertexOff_Tex_ST;
            uniform float _Smooth;
            uniform float _VertexOff_St;
            uniform sampler2D _Metallic_Tex; uniform float4 _Metallic_Tex_ST;
            uniform sampler2D _Roughness_Tex; uniform float4 _Roughness_Tex_ST;
            uniform sampler2D _Emission; uniform float4 _Emission_ST;
            uniform float _Emission_st;
            uniform float4 _Emission_C;
            uniform float4 _Multiple;
            uniform float _Vertex_X;
            uniform float _Vertex_Y;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float node_7884 = 0.0;
                float2 node_6152_tc_rcp = float2(1.0,1.0)/float2( _Multiple.r, _Multiple.g );
                float node_6152_ty = floor(node_7884 * node_6152_tc_rcp.x);
                float node_6152_tx = node_7884 - _Multiple.r * node_6152_ty;
                float2 node_6152 = (float2(((_Multiple.r*_Vertex_X)+o.uv0.r),(o.uv0.g+(_Vertex_Y*_Multiple.g))) + float2(node_6152_tx, node_6152_ty)) * node_6152_tc_rcp;
                float4 _VertexOff_Tex_var = tex2Dlod(_VertexOff_Tex,float4(TRANSFORM_TEX(node_6152, _VertexOff_Tex),0.0,0));
                v.vertex.xyz += (_VertexOff_Tex_var.rgb*v.normal*_VertexOff_St);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
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
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
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
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : SV_Target {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float4 _Emission_var = tex2D(_Emission,TRANSFORM_TEX(i.uv0, _Emission));
                float3 Emission = (_Emission_C.rgb*_Emission_var.rgb*_Emission_st);
                o.Emission = Emission;
                
                float node_8173_ang = (_Ang*3.141592654);
                float node_8173_spd = 1.0;
                float node_8173_cos = cos(node_8173_spd*node_8173_ang);
                float node_8173_sin = sin(node_8173_spd*node_8173_ang);
                float2 node_8173_piv = float2(0.5,0.5);
                float2 node_8173 = (mul(i.uv0-node_8173_piv,float2x2( node_8173_cos, -node_8173_sin, node_8173_sin, node_8173_cos))+node_8173_piv);
                float2 node_8893 = node_8173.rg;
                float node_3524 = (_Scale*-49.0+99.0);
                float2 node_5606 = float2(node_8893.r,pow(pow(node_8893.g,node_3524),node_3524));
                float4 _BaseColor_var = tex2D(_BaseColor,TRANSFORM_TEX(node_5606, _BaseColor));
                float3 diffColor = (_Color.rgb*_BaseColor_var.rgb*_BaseColor_var.a);
                float specularMonochrome;
                float3 specColor;
                float4 _Metallic_Tex_var = tex2D(_Metallic_Tex,TRANSFORM_TEX(i.uv0, _Metallic_Tex));
                float Metallic = (_Metallic_Tex_var.r*_Metallic_Tex_var.g*_Metallic_Tex_var.b*_Metallic);
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, Metallic, specColor, specularMonochrome );
                float4 _Roughness_Tex_var = tex2D(_Roughness_Tex,TRANSFORM_TEX(i.uv0, _Roughness_Tex));
                float Roughness = (dot(_Roughness_Tex_var.rgb,float3(0.3,0.59,0.11))*_Gloss);
                float roughness = Roughness;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
