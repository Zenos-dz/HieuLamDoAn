/**
 * TinyMCE version 6.7.0 (2023-08-30)
 */
!function(){"use strict";var e=tinymce.util.Tools.resolve("tinymce.PluginManager");let t=0;const n=e=>{const n=(new Date).getTime(),a=Math.floor(1e9*Math.random());return t++,e+"_"+a+t+String(n)},a=e=>t=>t.options.get(e),r=a("help_tabs"),o=a("forced_plugins"),i=("string",e=>"string"===(e=>{const t=typeof e;return null===e?"null":"object"===t&&Array.isArray(e)?"array":"object"===t&&(n=a=e,(r=String).prototype.isPrototypeOf(n)||(null===(o=a.constructor)||void 0===o?void 0:o.name)===r.name)?"string":t;var n,a,r,o})(e));const s=(void 0,e=>undefined===e);const l=e=>"function"==typeof e,c=(!1,()=>false);class m{constructor(e,t){this.tag=e,this.value=t}static some(e){return new m(!0,e)}static none(){return m.singletonNone}fold(e,t){return this.tag?t(this.value):e()}isSome(){return this.tag}isNone(){return!this.tag}map(e){return this.tag?m.some(e(this.value)):m.none()}bind(e){return this.tag?e(this.value):m.none()}exists(e){return this.tag&&e(this.value)}forall(e){return!this.tag||e(this.value)}filter(e){return!this.tag||e(this.value)?this:m.none()}getOr(e){return this.tag?this.value:e}or(e){return this.tag?this:e}getOrThunk(e){return this.tag?this.value:e()}orThunk(e){return this.tag?this:e()}getOrDie(e){if(this.tag)return this.value;throw new Error(null!=e?e:"Called getOrDie on None")}static from(e){return null==e?m.none():m.some(e)}getOrNull(){return this.tag?this.value:null}getOrUndefined(){return this.value}each(e){this.tag&&e(this.value)}toArray(){return this.tag?[this.value]:[]}toString(){return this.tag?`some(${this.value})`:"none()"}}m.singletonNone=new m(!1);const u=Array.prototype.slice,p=Array.prototype.indexOf,y=(e,t)=>{const n=e.length,a=new Array(n);for(let r=0;r<n;r++){const n=e[r];a[r]=t(n,r)}return a},h=(e,t)=>{const n=[];for(let a=0,r=e.length;a<r;a++){const r=e[a];t(r,a)&&n.push(r)}return n},d=(e,t)=>{const n=u.call(e,0);return n.sort(t),n},g=Object.keys,k=Object.hasOwnProperty,v=(e,t)=>k.call(e,t);var b=tinymce.util.Tools.resolve("tinymce.Resource"),f=tinymce.util.Tools.resolve("tinymce.util.I18n");const A=(e,t)=>b.load(`tinymce.html-i18n.help-keynav.${t}`,`${e}/js/i18n/keynav/${t}.js`),C=e=>A(e,f.getCode()).catch((()=>A(e,"en")));var w=tinymce.util.Tools.resolve("tinymce.Env");const S=e=>{const t=w.os.isMacOS()||w.os.isiOS(),n=t?{alt:"&#x2325;",ctrl:"&#x2303;",shift:"&#x21E7;",meta:"&#x2318;",access:"&#x2303;&#x2325;"}:{meta:"Ctrl ",access:"Shift + Alt "},a=e.split("+"),r=y(a,(e=>{const t=e.toLowerCase().trim();return v(n,t)?n[t]:e}));return t?r.join("").replace(/\s/,""):r.join("+")},M=[{shortcuts:["Meta + B"],action:"Bold"},{shortcuts:["Meta + I"],action:"Italic"},{shortcuts:["Meta + U"],action:"Underline"},{shortcuts:["Meta + A"],action:"Select all"},{shortcuts:["Meta + Y","Meta + Shift + Z"],action:"Redo"},{shortcuts:["Meta + Z"],action:"Undo"},{shortcuts:["Access + 1"],action:"Heading 1"},{shortcuts:["Access + 2"],action:"Heading 2"},{shortcuts:["Access + 3"],action:"Heading 3"},{shortcuts:["Access + 4"],action:"Heading 4"},{shortcuts:["Access + 5"],action:"Heading 5"},{shortcuts:["Access + 6"],action:"Heading 6"},{shortcuts:["Access + 7"],action:"Paragraph"},{shortcuts:["Access + 8"],action:"Div"},{shortcuts:["Access + 9"],action:"Address"},{shortcuts:["Alt + 0"],action:"Open help dialog"},{shortcuts:["Alt + F9"],action:"Focus to menubar"},{shortcuts:["Alt + F10"],action:"Focus to toolbar"},{shortcuts:["Alt + F11"],action:"Focus to element path"},{shortcuts:["Ctrl + F9"],action:"Focus to contextual toolbar"},{shortcuts:["Shift + Enter"],action:"Open popup menu for split buttons"},{shortcuts:["Meta + K"],action:"Insert link (if link plugin activated)"},{shortcuts:["Meta + S"],action:"Save (if save plugin activated)"},{shortcuts:["Meta + F"],action:"Find (if searchreplace plugin activated)"},{shortcuts:["Meta + Shift + F"],action:"Switch to or from fullscreen mode"}],T=()=>({name:"shortcuts",title:"Handy Shortcuts",items:[{type:"table",header:["Action","Shortcut"],cells:y(M,(e=>{const t=y(e.shortcuts,S).join(" or ");return[e.action,t]}))}]}),x=y([{key:"accordion",name:"Accordion"},{key:"advlist",name:"Advanced List"},{key:"anchor",name:"Anchor"},{key:"autolink",name:"Autolink"},{key:"autoresize",name:"Autoresize"},{key:"autosave",name:"Autosave"},{key:"charmap",name:"Character Map"},{key:"code",name:"Code"},{key:"codesample",name:"Code Sample"},{key:"colorpicker",name:"Color Picker"},{key:"directionality",name:"Directionality"},{key:"emoticons",name:"Emoticons"},{key:"fullscreen",name:"Full Screen"},{key:"help",name:"Help"},{key:"image",name:"Image"},{key:"importcss",name:"Import CSS"},{key:"insertdatetime",name:"Insert Date/Time"},{key:"link",name:"Link"},{key:"lists",name:"Lists"},{key:"media",name:"Media"},{key:"nonbreaking",name:"Nonbreaking"},{key:"pagebreak",name:"Page Break"},{key:"preview",name:"Preview"},{key:"quickbars",name:"Quick Toolbars"},{key:"save",name:"Save"},{key:"searchreplace",name:"Search and Replace"},{key:"table",name:"Table"},{key:"template",name:"Template"},{key:"textcolor",name:"Text Color"},{key:"visualblocks",name:"Visual Blocks"},{key:"visualchars",name:"Visual Characters"},{key:"wordcount",name:"Word Count"},{key:"a11ychecker",name:"Accessibility Checker",type:"premium"},{key:"advcode",name:"Advanced Code Editor",type:"premium"},{key:"advtable",name:"Advanced Tables",type:"premium"},{key:"advtemplate",name:"Advanced Templates",type:"premium",slug:"advanced-templates"},{key:"ai",name:"AI Assistant",type:"premium"},{key:"casechange",name:"Case Change",type:"premium"},{key:"checklist",name:"Checklist",type:"premium"},{key:"editimage",name:"Enhanced Image Editing",type:"premium"},{key:"footnotes",name:"Footnotes",type:"premium"},{key:"typography",name:"Advanced Typography",type:"premium",slug:"advanced-typography"},{key:"mediaembed",name:"Enhanced Media Embed",type:"premium",slug:"introduction-to-mediaembed"},{key:"export",name:"Export",type:"premium"},{key:"formatpainter",name:"Format Painter",type:"premium"},{key:"inlinecss",name:"Inline CSS",type:"premium",slug:"inline-css"},{key:"linkchecker",name:"Link Checker",type:"premium"},{key:"mentions",name:"Mentions",type:"premium"},{key:"mergetags",name:"Merge Tags",type:"premium"},{key:"pageembed",name:"Page Embed",type:"premium"},{key:"permanentpen",name:"Permanent Pen",type:"premium"},{key:"powerpaste",name:"PowerPaste",type:"premium",slug:"introduction-to-powerpaste"},{key:"rtc",name:"Real-Time Collaboration",type:"premium",slug:"rtc-introduction"},{key:"tinymcespellchecker",name:"Spell Checker Pro",type:"premium",slug:"introduction-to-tiny-spellchecker"},{key:"autocorrect",name:"Spelling Autocorrect",type:"premium"},{key:"tableofcontents",name:"Table of Contents",type:"premium"},{key:"tinycomments",name:"Tiny Comments",type:"premium",slug:"introduction-to-tiny-comments"},{key:"tinydrive",name:"Tiny Drive",type:"premium",slug:"tinydrive-introduction"}],(e=>({...e,type:e.type||"opensource",slug:e.slug||e.key}))),_=e=>{const t=e=>`<a data-alloy-tabstop="true" tabindex="-1" href="${e.url}" target="_blank" rel="noopener">${e.name}</a>`,n=(e,n)=>{return(a=x,r=e=>e.key===n,((e,t,n)=>{for(let a=0,r=e.length;a<r;a++){const r=e[a];if(t(r,a))return m.some(r);if(n(r,a))break}return m.none()})(a,r,c)).fold((()=>((e,n)=>{const a=e.plugins[n].getMetadata;if(l(a)){const e=a();return{name:e.name,html:t(e)}}return{name:n,html:n}})(e,n)),(e=>{const n="premium"===e.type?`${e.name}*`:e.name;return{name:n,html:t({name:n,url:`https://www.tiny.cloud/docs/tinymce/6/${e.slug}/`})}}));var a,r},a=e=>{const t=(e=>{const t=g(e.plugins),n=o(e);return s(n)?t:h(t,(e=>!(((e,t)=>p.call(e,t))(n,e)>-1)))})(e),a=d(y(t,(t=>n(e,t))),((e,t)=>e.name.localeCompare(t.name))),r=y(a,(e=>"<li>"+e.html+"</li>")),i=r.length,l=r.join("");return"<p><b>"+f.translate(["Plugins installed ({0}):",i])+"</b></p><ul>"+l+"</ul>"},r={type:"htmlpanel",presets:"document",html:[(e=>null==e?"":"<div>"+a(e)+"</div>")(e),(()=>{const e=h(x,(({type:e})=>"premium"===e)),t=d(y(e,(e=>e.name)),((e,t)=>e.localeCompare(t))),n=y(t,(e=>`<li>${e}</li>`)).join("");return"<div><p><b>"+f.translate("Premium plugins:")+"</b></p><ul>"+n+'<li class="tox-help__more-link" "><a href="https://www.tiny.cloud/pricing/?utm_campaign=editor_referral&utm_medium=help_dialog&utm_source=tinymce" rel="noopener" target="_blank" data-alloy-tabstop="true" tabindex="-1">'+f.translate("Learn more...")+"</a></li></ul></div>"})()].join("")};return{name:"plugins",title:"Plugins",items:[r]}};var O=tinymce.util.Tools.resolve("tinymce.EditorManager");const P=(e,t,a)=>()=>{(async(e,t,a)=>{const o=T(),s=await(async e=>({name:"keyboardnav",title:"Keyboard Navigation",items:[{type:"htmlpanel",presets:"document",html:await C(e)}]}))(a),l=_(e),c=(()=>{var e,t;const n='<a data-alloy-tabstop="true" tabindex="-1" href="https://www.tiny.cloud/docs/tinymce/6/changelog/?utm_campaign=editor_referral&utm_medium=help_dialog&utm_source=tinymce" rel="noopener" target="_blank">TinyMCE '+(e=O.majorVersion,t=O.minorVersion,(0===e.indexOf("@")?"X.X.X":e+"."+t)+"</a>");return{name:"versions",title:"Version",items:[{type:"htmlpanel",html:"<p>"+f.translate(["You are using {0}",n])+"</p>",presets:"document"}]}})(),u={[o.name]:o,[s.name]:s,[l.name]:l,[c.name]:c,...t.get()};return m.from(r(e)).fold((()=>(e=>{const t=g(e),n=t.indexOf("versions");return-1!==n&&(t.splice(n,1),t.push("versions")),{tabs:e,names:t}})(u)),(e=>((e,t)=>{const a={},r=y(e,(e=>{var r;if(i(e))return v(t,e)&&(a[e]=t[e]),e;{const t=null!==(r=e.name)&&void 0!==r?r:n("tab-name");return a[t]=e,t}}));return{tabs:a,names:r}})(e,u)))})(e,t,a).then((({tabs:t,names:n})=>{const a={type:"tabpanel",tabs:(e=>{const t=[],n=e=>{t.push(e)};for(let t=0;t<e.length;t++)e[t].each(n);return t})(y(n,(e=>{return v(n=t,a=e)?m.from(n[a]):m.none();var n,a})))};e.windowManager.open({title:"Help",size:"medium",body:a,buttons:[{type:"cancel",name:"close",text:"Close",primary:!0}],initialData:{}})}))};e.add("help",((e,t)=>{const a=(e=>{let t={};return{get:()=>t,set:e=>{t=e}}})(),r=(e=>({addTab:t=>{var a;const r=null!==(a=t.name)&&void 0!==a?a:n("tab-name"),o=e.get();o[r]=t,e.set(o)}}))(a);(e=>{(0,e.options.register)("help_tabs",{processor:"array"})})(e);const o=P(e,a,t);return((e,t)=>{e.ui.registry.addButton("help",{icon:"help",tooltip:"Help",onAction:t}),e.ui.registry.addMenuItem("help",{text:"Help",icon:"help",shortcut:"Alt+0",onAction:t})})(e,o),((e,t)=>{e.addCommand("mceHelp",t)})(e,o),e.shortcuts.add("Alt+0","Open help dialog","mceHelp"),((e,t)=>{e.on("init",(()=>{C(t)}))})(e,t),r}))}();