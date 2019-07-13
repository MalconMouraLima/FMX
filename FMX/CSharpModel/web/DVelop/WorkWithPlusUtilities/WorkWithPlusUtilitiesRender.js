/*!
 * Bootstrap-select v1.12.4 (http://silviomoreto.github.io/bootstrap-select)
 *
 * Copyright 2013-2017 bootstrap-select
 * Licensed under MIT (https://github.com/silviomoreto/bootstrap-select/blob/master/LICENSE)
 */
(function(a,b){if(typeof define==="function"&&define.amd){define(["jquery"],function(c){return(b(c))})}else{if(typeof module==="object"&&module.exports){module.exports=b(require("jquery"))}else{b(a.jQuery)}}}(this,function(a){(function(g){if(!String.prototype.includes){(function(){var r={}.toString;
var o=(function(){try{var v={};var u=Object.defineProperty;var s=u(v,v,v)&&u}catch(t){}return s}());var q="".indexOf;var p=function(x){if(this==null){throw new TypeError()}var v=String(this);if(x&&r.call(x)=="[object RegExp]"){throw new TypeError()}var t=v.length;var u=String(x);var w=u.length;var s=arguments.length>1?arguments[1]:undefined;var z=s?Number(s):0;if(z!=z){z=0}var y=Math.min(Math.max(z,0),t);if(w+y>t){return false}return q.call(v,u,z)!=-1};if(o){o(String.prototype,"includes",{value:p,configurable:true,writable:true})
}else{String.prototype.includes=p}}())}if(!String.prototype.startsWith){(function(){var o=(function(){try{var u={};var t=Object.defineProperty;var r=t(u,u,u)&&t}catch(s){}return r}());var q={}.toString;var p=function(y){if(this==null){throw new TypeError()}var v=String(this);if(y&&q.call(y)=="[object RegExp]"){throw new TypeError()}var r=v.length;var z=String(y);var t=z.length;var u=arguments.length>1?arguments[1]:undefined;var x=u?Number(u):0;if(x!=x){x=0}var s=Math.min(Math.max(x,0),r);if(t+s>r){return false
}var w=-1;while(++w<t){if(v.charCodeAt(s+w)!=z.charCodeAt(w)){return false}}return true};if(o){o(String.prototype,"startsWith",{value:p,configurable:true,writable:true})}else{String.prototype.startsWith=p}}())}if(!Object.keys){Object.keys=function(s,p,q){q=[];for(p in s){q.hasOwnProperty.call(s,p)&&q.push(p)}return q}}var e={useDefault:false,_set:g.valHooks.select.set};g.valHooks.select.set=function(o,p){if(p&&!e.useDefault){g(o).data("selected",true)}return e._set.apply(this,arguments)};var n=null;
var h=(function(){try{new Event("change");return true}catch(o){return false}})();g.fn.triggerNative=function(o){var p=this[0],q;if(p.dispatchEvent){if(h){q=new Event(o,{bubbles:true})}else{q=document.createEvent("Event");q.initEvent(o,true,false)}p.dispatchEvent(q)}else{if(p.fireEvent){q=document.createEventObject();q.eventType=o;p.fireEvent("on"+o,q)}else{this.trigger(o)}}};g.expr.pseudos.icontains=function(r,o,q){var s=g(r).find("a");var p=(s.data("tokens")||s.text()).toString().toUpperCase();return p.includes(q[3].toUpperCase())
};g.expr.pseudos.ibegins=function(r,o,q){var s=g(r).find("a");var p=(s.data("tokens")||s.text()).toString().toUpperCase();return p.startsWith(q[3].toUpperCase())};g.expr.pseudos.aicontains=function(r,o,q){var s=g(r).find("a");var p=(s.data("tokens")||s.data("normalizedText")||s.text()).toString().toUpperCase();return p.includes(q[3].toUpperCase())};g.expr.pseudos.aibegins=function(r,o,q){var s=g(r).find("a");var p=(s.data("tokens")||s.data("normalizedText")||s.text()).toString().toUpperCase();return p.startsWith(q[3].toUpperCase())
};function c(p){var o=[{re:/[\xC0-\xC6]/g,ch:"A"},{re:/[\xE0-\xE6]/g,ch:"a"},{re:/[\xC8-\xCB]/g,ch:"E"},{re:/[\xE8-\xEB]/g,ch:"e"},{re:/[\xCC-\xCF]/g,ch:"I"},{re:/[\xEC-\xEF]/g,ch:"i"},{re:/[\xD2-\xD6]/g,ch:"O"},{re:/[\xF2-\xF6]/g,ch:"o"},{re:/[\xD9-\xDC]/g,ch:"U"},{re:/[\xF9-\xFC]/g,ch:"u"},{re:/[\xC7-\xE7]/g,ch:"c"},{re:/[\xD1]/g,ch:"N"},{re:/[\xF1]/g,ch:"n"}];g.each(o,function(){p=p?p.replace(this.re,this.ch):""});return p}var i={"&":"&amp;","<":"&lt;",">":"&gt;",'"':"&quot;","'":"&#x27;","`":"&#x60;"};
var b={"&amp;":"&","&lt;":"<","&gt;":">","&quot;":'"',"&#x27;":"'","&#x60;":"`"};var f=function(s){var p=function(t){return s[t]};var r="(?:"+Object.keys(s).join("|")+")";var q=RegExp(r);var o=RegExp(r,"g");return function(t){t=t==null?"":""+t;return q.test(t)?t.replace(o,p):t}};var m=f(i);var j=f(b);var l=function(q,p){if(!e.useDefault){g.valHooks.select.set=e._set;e.useDefault=true}this.$element=g(q);this.$newElement=null;this.$button=null;this.$menu=null;this.$lis=null;this.options=p;if(this.options.title===null){this.options.title=this.$element.attr("title")
}var o=this.options.windowPadding;if(typeof o==="number"){this.options.windowPadding=[o,o,o,o]}this.val=l.prototype.val;this.render=l.prototype.render;this.refresh=l.prototype.refresh;this.setStyle=l.prototype.setStyle;this.selectAll=l.prototype.selectAll;this.deselectAll=l.prototype.deselectAll;this.destroy=l.prototype.destroy;this.remove=l.prototype.remove;this.show=l.prototype.show;this.hide=l.prototype.hide;this.init()};l.VERSION="1.12.4";l.DEFAULTS={noneSelectedText:"Nothing selected",noneResultsText:"No results matched {0}",countSelectedText:function(p,o){return(p==1)?"{0} item selected":"{0} items selected"
},maxOptionsText:function(o,p){return[(o==1)?"Limit reached ({n} item max)":"Limit reached ({n} items max)",(p==1)?"Group limit reached ({n} item max)":"Group limit reached ({n} items max)"]},selectAllText:"Select All",deselectAllText:"Deselect All",doneButton:false,doneButtonText:"Close",multipleSeparator:", ",styleBase:"btn",style:"btn-default",size:"auto",title:null,selectedTextFormat:"values",width:false,container:false,hideDisabled:false,showSubtext:false,showIcon:true,showContent:true,dropupAuto:true,header:false,liveSearch:false,liveSearchPlaceholder:null,liveSearchNormalize:false,liveSearchStyle:"contains",actionsBox:false,iconBase:"glyphicon",tickIcon:"glyphicon-ok",showTick:false,template:{caret:'<span class="caret"></span>'},maxOptions:false,mobile:false,selectOnTab:false,dropdownAlignRight:false,windowPadding:0};
l.prototype={constructor:l,init:function(){var o=this,p=this.$element.attr("id");this.$element.addClass("bs-select-hidden");this.liObj={};this.multiple=this.$element.prop("multiple");this.autofocus=this.$element.prop("autofocus");this.$newElement=this.createView();this.$element.after(this.$newElement).appendTo(this.$newElement);this.$button=this.$newElement.children("button");this.$menu=this.$newElement.children(".dropdown-menu");this.$menuInner=this.$menu.children(".inner");this.$searchbox=this.$menu.find("input");
this.$element.removeClass("bs-select-hidden");if(this.options.dropdownAlignRight===true){this.$menu.addClass("dropdown-menu-right")}if(typeof p!=="undefined"){this.$button.attr("data-id",p);g('label[for="'+p+'"]').click(function(q){q.preventDefault();o.$button.focus()})}this.checkDisabled();this.clickListener();if(this.options.liveSearch){this.liveSearchListener()}this.render();this.setStyle();this.setWidth();if(this.options.container){this.selectPosition()}this.$menu.data("this",this);this.$newElement.data("this",this);
if(this.options.mobile){this.mobile()}this.$newElement.on({"hide.bs.dropdown":function(q){o.$menuInner.attr("aria-expanded",false);o.$element.trigger("hide.bs.select",q)},"hidden.bs.dropdown":function(q){o.$element.trigger("hidden.bs.select",q)},"show.bs.dropdown":function(q){o.$menuInner.attr("aria-expanded",true);o.$element.trigger("show.bs.select",q)},"shown.bs.dropdown":function(q){o.$element.trigger("shown.bs.select",q)}});if(o.$element[0].hasAttribute("required")){this.$element.on("invalid",function(){o.$button.addClass("bs-invalid");
o.$element.on({"focus.bs.select":function(){o.$button.focus();o.$element.off("focus.bs.select")},"shown.bs.select":function(){o.$element.val(o.$element.val()).off("shown.bs.select")},"rendered.bs.select":function(){if(this.validity.valid){o.$button.removeClass("bs-invalid")}o.$element.off("rendered.bs.select")}});o.$button.on("blur.bs.select",function(){o.$element.focus().blur();o.$button.off("blur.bs.select")})})}setTimeout(function(){o.$element.trigger("loaded.bs.select")})},createDropdown:function(){var t=(this.multiple||this.options.showTick)?" show-tick":"",p=this.$element.parent().hasClass("input-group")?" input-group-btn":"",v=this.autofocus?" autofocus":"";
var u=this.options.header?'<div class="popover-title"><button type="button" class="close" aria-hidden="true">&times;</button>'+this.options.header+"</div>":"";var s=this.options.liveSearch?'<div class="bs-searchbox"><input type="text" class="form-control" autocomplete="off"'+(null===this.options.liveSearchPlaceholder?"":' placeholder="'+m(this.options.liveSearchPlaceholder)+'"')+' role="textbox" aria-label="Search"></div>':"";var r=this.multiple&&this.options.actionsBox?'<div class="bs-actionsbox"><div class="btn-group btn-group-sm btn-block"><button type="button" class="actions-btn bs-select-all btn btn-default">'+this.options.selectAllText+'</button><button type="button" class="actions-btn bs-deselect-all btn btn-default">'+this.options.deselectAllText+"</button></div></div>":"";
var o=this.multiple&&this.options.doneButton?'<div class="bs-donebutton"><div class="btn-group btn-block"><button type="button" class="btn btn-sm btn-default">'+this.options.doneButtonText+"</button></div></div>":"";var q='<div class="btn-group bootstrap-select'+t+p+'"><button type="button" class="'+this.options.styleBase+' dropdown-toggle" data-toggle="dropdown"'+v+' role="button"><span class="filter-option pull-left"></span>&nbsp;<span class="bs-caret">'+this.options.template.caret+'</span></button><div class="dropdown-menu open" role="combobox">'+u+s+r+'<ul class="dropdown-menu inner" role="listbox" aria-expanded="false"></ul>'+o+"</div></div>";
return g(q)},createView:function(){var p=this.createDropdown(),o=this.createLi();p.find("ul")[0].innerHTML=o;return p},reloadLi:function(){var o=this.createLi();this.$menuInner[0].innerHTML=o},createLi:function(){var u=this,t=[],x=0,o=document.createElement("option"),r=-1;var w=function(B,z,A,y){return"<li"+((typeof A!=="undefined"&&""!==A)?' class="'+A+'"':"")+((typeof z!=="undefined"&&null!==z)?' data-original-index="'+z+'"':"")+((typeof y!=="undefined"&&null!==y)?'data-optgroup="'+y+'"':"")+">"+B+"</li>"
};var q=function(B,y,A,z){return'<a tabindex="0"'+(typeof y!=="undefined"?' class="'+y+'"':"")+(A?' style="'+A+'"':"")+(u.options.liveSearchNormalize?' data-normalized-text="'+c(m(g(B).html()))+'"':"")+(typeof z!=="undefined"||z!==null?' data-tokens="'+z+'"':"")+' role="option">'+B+'<span class="'+u.options.iconBase+" "+u.options.tickIcon+' check-mark"></span></a>'};if(this.options.title&&!this.multiple){r--;if(!this.$element.find(".bs-title-option").length){var s=this.$element[0];o.className="bs-title-option";
o.innerHTML=this.options.title;o.value="";s.insertBefore(o,s.firstChild);var v=g(s.options[s.selectedIndex]);if(v.attr("selected")===undefined&&this.$element.data("selected")===undefined){o.selected=true}}}var p=this.$element.find("option");p.each(function(C){var B=g(this);r++;if(B.hasClass("bs-title-option")){return}var E=this.className||"",A=m(this.style.cssText),F=B.data("content")?B.data("content"):B.html(),H=B.data("tokens")?B.data("tokens"):null,R=typeof B.data("subtext")!=="undefined"?'<small class="text-muted">'+B.data("subtext")+"</small>":"",O=typeof B.data("icon")!=="undefined"?'<span class="'+u.options.iconBase+" "+B.data("icon")+'"></span> ':"",J=B.parent(),z=J[0].tagName==="OPTGROUP",M=z&&J[0].disabled,G=this.disabled||M,y;
if(O!==""&&G){O="<span>"+O+"</span>"}if(u.options.hideDisabled&&(G&&!z||M)){y=B.data("prevHiddenIndex");B.next().data("prevHiddenIndex",(y!==undefined?y:C));r--;return}if(!B.data("content")){F=O+'<span class="text">'+F+R+"</span>"}if(z&&B.data("divider")!==true){if(u.options.hideDisabled&&G){if(J.data("allOptionsDisabled")===undefined){var N=J.children();J.data("allOptionsDisabled",N.filter(":disabled").length===N.length)}if(J.data("allOptionsDisabled")){r--;return}}var P=" "+J[0].className||"";if(B.index()===0){x+=1;
var D=J[0].label,Q=typeof J.data("subtext")!=="undefined"?'<small class="text-muted">'+J.data("subtext")+"</small>":"",K=J.data("icon")?'<span class="'+u.options.iconBase+" "+J.data("icon")+'"></span> ':"";D=K+'<span class="text">'+m(D)+Q+"</span>";if(C!==0&&t.length>0){r++;t.push(w("",null,"divider",x+"div"))}r++;t.push(w(D,null,"dropdown-header"+P,x))}if(u.options.hideDisabled&&G){r--;return}t.push(w(q(F,"opt "+E+P,A,H),C,"",x))}else{if(B.data("divider")===true){t.push(w("",C,"divider"))}else{if(B.data("hidden")===true){y=B.data("prevHiddenIndex");
B.next().data("prevHiddenIndex",(y!==undefined?y:C));t.push(w(q(F,E,A,H),C,"hidden is-hidden"))}else{var I=this.previousElementSibling&&this.previousElementSibling.tagName==="OPTGROUP";if(!I&&u.options.hideDisabled){y=B.data("prevHiddenIndex");if(y!==undefined){var L=p.eq(y)[0].previousElementSibling;if(L&&L.tagName==="OPTGROUP"&&!L.disabled){I=true}}}if(I){r++;t.push(w("",null,"divider",x+"div"))}t.push(w(q(F,E,A,H),C))}}}u.liObj[C]=r});if(!this.multiple&&this.$element.find("option:selected").length===0&&!this.options.title){this.$element.find("option").eq(0).prop("selected",true).attr("selected","selected")
}return t.join("")},findLis:function(){if(this.$lis==null){this.$lis=this.$menu.find("li")}return this.$lis},render:function(s){var r=this,o,p=this.$element.find("option");if(s!==false){p.each(function(x){var y=r.findLis().eq(r.liObj[x]);r.setDisabled(x,this.disabled||this.parentNode.tagName==="OPTGROUP"&&this.parentNode.disabled,y);r.setSelected(x,this.selected,y)})}this.togglePlaceholder();this.tabIndex();var q=p.map(function(){if(this.selected){if(r.options.hideDisabled&&(this.disabled||this.parentNode.tagName==="OPTGROUP"&&this.parentNode.disabled)){return
}var z=g(this),y=z.data("icon")&&r.options.showIcon?'<i class="'+r.options.iconBase+" "+z.data("icon")+'"></i> ':"",x;if(r.options.showSubtext&&z.data("subtext")&&!r.multiple){x=' <small class="text-muted">'+z.data("subtext")+"</small>"}else{x=""}if(typeof z.attr("title")!=="undefined"){return z.attr("title")}else{if(z.data("content")&&r.options.showContent){return z.data("content").toString()}else{return y+z.html()+x}}}}).toArray();var u=!this.multiple?q[0]:q.join(this.options.multipleSeparator);
if(this.multiple&&this.options.selectedTextFormat.indexOf("count")>-1){var t=this.options.selectedTextFormat.split(">");if((t.length>1&&q.length>t[1])||(t.length==1&&q.length>=2)){o=this.options.hideDisabled?", [disabled]":"";var v=p.not('[data-divider="true"], [data-hidden="true"]'+o).length,w=(typeof this.options.countSelectedText==="function")?this.options.countSelectedText(q.length,v):this.options.countSelectedText;u=w.replace("{0}",q.length.toString()).replace("{1}",v.toString())}}if(this.options.title==undefined){this.options.title=this.$element.attr("title")
}if(this.options.selectedTextFormat=="static"){u=this.options.title}if(!u){u=typeof this.options.title!=="undefined"?this.options.title:this.options.noneSelectedText}this.$button.attr("title",j(g.trim(u.replace(/<[^>]*>?/g,""))));this.$button.children(".filter-option").html(u);this.$element.trigger("rendered.bs.select")},setStyle:function(q,p){if(this.$element.attr("class")){this.$newElement.addClass(this.$element.attr("class").replace(/selectpicker|mobile-device|bs-select-hidden|validate\[.*\]/gi,""))
}var o=q?q:this.options.style;if(p=="add"){this.$button.addClass(o)}else{if(p=="remove"){this.$button.removeClass(o)}else{this.$button.removeClass(this.options.style);this.$button.addClass(o)}}},liHeight:function(u){if(!u&&(this.options.size===false||this.sizeInfo)){return}var s=document.createElement("div"),o=document.createElement("div"),y=document.createElement("ul"),G=document.createElement("li"),F=document.createElement("li"),K=document.createElement("a"),E=document.createElement("span"),J=this.options.header&&this.$menu.find(".popover-title").length>0?this.$menu.find(".popover-title")[0].cloneNode(true):null,z=this.options.liveSearch?document.createElement("div"):null,A=this.options.actionsBox&&this.multiple&&this.$menu.find(".bs-actionsbox").length>0?this.$menu.find(".bs-actionsbox")[0].cloneNode(true):null,r=this.options.doneButton&&this.multiple&&this.$menu.find(".bs-donebutton").length>0?this.$menu.find(".bs-donebutton")[0].cloneNode(true):null;
E.className="text";s.className=this.$menu[0].parentNode.className+" open";o.className="dropdown-menu open";y.className="dropdown-menu inner";G.className="divider";E.appendChild(document.createTextNode("Inner text"));K.appendChild(E);F.appendChild(K);y.appendChild(F);y.appendChild(G);if(J){o.appendChild(J)}if(z){var C=document.createElement("input");z.className="bs-searchbox";C.className="form-control";z.appendChild(C);o.appendChild(z)}if(A){o.appendChild(A)}o.appendChild(y);if(r){o.appendChild(r)
}s.appendChild(o);document.body.appendChild(s);var q=K.offsetHeight,I=J?J.offsetHeight:0,B=z?z.offsetHeight:0,x=A?A.offsetHeight:0,t=r?r.offsetHeight:0,D=g(G).outerHeight(true),p=typeof getComputedStyle==="function"?getComputedStyle(o):false,v=p?null:g(o),H={vert:parseInt(p?p.paddingTop:v.css("paddingTop"))+parseInt(p?p.paddingBottom:v.css("paddingBottom"))+parseInt(p?p.borderTopWidth:v.css("borderTopWidth"))+parseInt(p?p.borderBottomWidth:v.css("borderBottomWidth")),horiz:parseInt(p?p.paddingLeft:v.css("paddingLeft"))+parseInt(p?p.paddingRight:v.css("paddingRight"))+parseInt(p?p.borderLeftWidth:v.css("borderLeftWidth"))+parseInt(p?p.borderRightWidth:v.css("borderRightWidth"))},w={vert:H.vert+parseInt(p?p.marginTop:v.css("marginTop"))+parseInt(p?p.marginBottom:v.css("marginBottom"))+2,horiz:H.horiz+parseInt(p?p.marginLeft:v.css("marginLeft"))+parseInt(p?p.marginRight:v.css("marginRight"))+2};
document.body.removeChild(s);this.sizeInfo={liHeight:q,headerHeight:I,searchHeight:B,actionsHeight:x,doneButtonHeight:t,dividerHeight:D,menuPadding:H,menuExtras:w}},setSize:function(){this.findLis();this.liHeight();if(this.options.header){this.$menu.css("padding-top",0)}if(this.options.size===false){return}var z=this,w=this.$menu,s=this.$menuInner,E=g(window),M=this.$newElement[0].offsetHeight,O=this.$newElement[0].offsetWidth,t=this.sizeInfo.liHeight,I=this.sizeInfo.headerHeight,B=this.sizeInfo.searchHeight,y=this.sizeInfo.actionsHeight,u=this.sizeInfo.doneButtonHeight,A=this.sizeInfo.dividerHeight,H=this.sizeInfo.menuPadding,x=this.sizeInfo.menuExtras,F=this.options.hideDisabled?".disabled":"",G,o,C,q,N,L,v,K,J=function(){var S=z.$newElement.offset(),Q=g(z.options.container),R;
if(z.options.container&&!Q.is("body")){R=Q.offset();R.top+=parseInt(Q.css("borderTopWidth"));R.left+=parseInt(Q.css("borderLeftWidth"))}else{R={top:0,left:0}}var P=z.options.windowPadding;N=S.top-R.top-E.scrollTop();L=E.height()-N-M-R.top-P[2];v=S.left-R.left-E.scrollLeft();K=E.width()-v-O-R.left-P[1];N-=P[0];v-=P[3]};J();if(this.options.size==="auto"){var r=function(){var S,R=function(V,U){return function(W){if(U){return(W.classList?W.classList.contains(V):g(W).hasClass(V))}else{return !(W.classList?W.classList.contains(V):g(W).hasClass(V))
}}},Q=z.$menuInner[0].getElementsByTagName("li"),P=Array.prototype.filter?Array.prototype.filter.call(Q,R("hidden",false)):z.$lis.not(".hidden"),T=Array.prototype.filter?Array.prototype.filter.call(P,R("dropdown-header",true)):P.filter(".dropdown-header");J();G=L-x.vert;o=K-x.horiz;if(z.options.container){if(!w.data("height")){w.data("height",w.height())}C=w.data("height");if(!w.data("width")){w.data("width",w.width())}q=w.data("width")}else{C=w.height();q=w.width()}if(z.options.dropupAuto){z.$newElement.toggleClass("dropup",N>L&&(G-x.vert)<C)
}if(z.$newElement.hasClass("dropup")){G=N-x.vert}if(z.options.dropdownAlignRight==="auto"){w.toggleClass("dropdown-menu-right",v>K&&(o-x.horiz)<(q-O))}if((P.length+T.length)>3){S=t*3+x.vert-2}else{S=0}w.css({"max-height":G+"px",overflow:"hidden","min-height":S+I+B+y+u+"px"});s.css({"max-height":G-I-B-y-u-H.vert+"px","overflow-y":"auto","min-height":Math.max(S-H.vert,0)+"px"})};r();this.$searchbox.off("input.getSize propertychange.getSize").on("input.getSize propertychange.getSize",r);E.off("resize.getSize scroll.getSize").on("resize.getSize scroll.getSize",r)
}else{if(this.options.size&&this.options.size!="auto"&&this.$lis.not(F).length>this.options.size){var D=this.$lis.not(".divider").not(F).children().slice(0,this.options.size).last().parent().index(),p=this.$lis.slice(0,D+1).filter(".divider").length;G=t*this.options.size+p*A+H.vert;if(z.options.container){if(!w.data("height")){w.data("height",w.height())}C=w.data("height")}else{C=w.height()}if(z.options.dropupAuto){this.$newElement.toggleClass("dropup",N>L&&(G-x.vert)<C)}w.css({"max-height":G+I+B+y+u+"px",overflow:"hidden","min-height":""});
s.css({"max-height":G-H.vert+"px","overflow-y":"auto","min-height":""})}}},setWidth:function(){if(this.options.width==="auto"){this.$menu.css("min-width","0");var p=this.$menu.parent().clone().appendTo("body"),o=this.options.container?this.$newElement.clone().appendTo("body"):p,q=p.children(".dropdown-menu").outerWidth(),r=o.css("width","auto").children("button").outerWidth();p.remove();o.remove();this.$newElement.css("width",Math.max(q,r)+"px")}else{if(this.options.width==="fit"){this.$menu.css("min-width","");
this.$newElement.css("width","").addClass("fit-width")}else{if(this.options.width){this.$menu.css("min-width","");this.$newElement.css("width",this.options.width)}else{this.$menu.css("min-width","");this.$newElement.css("width","")}}}if(this.$newElement.hasClass("fit-width")&&this.options.width!=="fit"){this.$newElement.removeClass("fit-width")}},selectPosition:function(){this.$bsContainer=g('<div class="bs-container" />');var p=this,q=g(this.options.container),t,s,r,o=function(u){p.$bsContainer.addClass(u.attr("class").replace(/form-control|fit-width/gi,"")).toggleClass("dropup",u.hasClass("dropup"));
t=u.offset();if(!q.is("body")){s=q.offset();s.top+=parseInt(q.css("borderTopWidth"))-q.scrollTop();s.left+=parseInt(q.css("borderLeftWidth"))-q.scrollLeft()}else{s={top:0,left:0}}r=u.hasClass("dropup")?0:u[0].offsetHeight;p.$bsContainer.css({top:t.top-s.top+r,left:t.left-s.left,width:u[0].offsetWidth})};this.$button.on("click",function(){var u=g(this);if(p.isDisabled()){return}o(p.$newElement);p.$bsContainer.appendTo(p.options.container).toggleClass("open",!u.hasClass("open")).append(p.$menu)});g(window).on("resize scroll",function(){o(p.$newElement)
});this.$element.on("hide.bs.select",function(){p.$menu.data("height",p.$menu.height());p.$bsContainer.detach()})},setSelected:function(o,q,p){if(!p){this.togglePlaceholder();p=this.findLis().eq(this.liObj[o])}p.toggleClass("selected",q).find("a").attr("aria-selected",q)},setDisabled:function(o,q,p){if(!p){p=this.findLis().eq(this.liObj[o])}if(q){p.addClass("disabled").children("a").attr("href","#").attr("tabindex",-1).attr("aria-disabled",true)}else{p.removeClass("disabled").children("a").removeAttr("href").attr("tabindex",0).attr("aria-disabled",false)
}},isDisabled:function(){return this.$element[0].disabled},checkDisabled:function(){var o=this;if(this.isDisabled()){this.$newElement.addClass("disabled");this.$button.addClass("disabled").attr("tabindex",-1).attr("aria-disabled",true)}else{if(this.$button.hasClass("disabled")){this.$newElement.removeClass("disabled");this.$button.removeClass("disabled").attr("aria-disabled",false)}if(this.$button.attr("tabindex")==-1&&!this.$element.data("tabindex")){this.$button.removeAttr("tabindex")}}this.$button.click(function(){return !o.isDisabled()
})},togglePlaceholder:function(){var o=this.$element.val();this.$button.toggleClass("bs-placeholder",o===null||o===""||(o.constructor===Array&&o.length===0))},tabIndex:function(){if(this.$element.data("tabindex")!==this.$element.attr("tabindex")&&(this.$element.attr("tabindex")!==-98&&this.$element.attr("tabindex")!=="-98")){this.$element.data("tabindex",this.$element.attr("tabindex"));this.$button.attr("tabindex",this.$element.data("tabindex"))}this.$element.attr("tabindex",-98)},clickListener:function(){var o=this,p=g(document);
p.data("spaceSelect",false);this.$button.on("keyup",function(q){if(/(32)/.test(q.keyCode.toString(10))&&p.data("spaceSelect")){q.preventDefault();p.data("spaceSelect",false)}});this.$button.on("click",function(){o.setSize()});this.$element.on("shown.bs.select",function(){if(!o.options.liveSearch&&!o.multiple){o.$menuInner.find(".selected a").focus()}else{if(!o.multiple){var q=o.liObj[o.$element[0].selectedIndex];if(typeof q!=="number"||o.options.size===false){return}var r=o.$lis.eq(q)[0].offsetTop-o.$menuInner[0].offsetTop;
r=r-o.$menuInner[0].offsetHeight/2+o.sizeInfo.liHeight/2;o.$menuInner[0].scrollTop=r}}});this.$menuInner.on("click","li a",function(H){var w=g(this),r=w.parent().data("originalIndex"),F=o.$element.val(),y=o.$element.prop("selectedIndex"),z=true;if(o.multiple&&o.options.maxOptions!==1){H.stopPropagation()}H.preventDefault();if(!o.isDisabled()&&!w.parent().hasClass("disabled")){var D=o.$element.find("option"),E=D.eq(r),t=E.prop("selected"),C=E.parent("optgroup"),J=o.options.maxOptions,A=C.data("maxOptions")||false;
if(!o.multiple){D.prop("selected",false);E.prop("selected",true);o.$menuInner.find(".selected").removeClass("selected").find("a").attr("aria-selected",false);o.setSelected(r,true)}else{E.prop("selected",!t);o.setSelected(r,!t);w.blur();if(J!==false||A!==false){var s=J<D.filter(":selected").length,v=A<C.find("option:selected").length;if((J&&s)||(A&&v)){if(J&&J==1){D.prop("selected",false);E.prop("selected",true);o.$menuInner.find(".selected").removeClass("selected");o.setSelected(r,true)}else{if(A&&A==1){C.find("option:selected").prop("selected",false);
E.prop("selected",true);var G=w.parent().data("optgroup");o.$menuInner.find('[data-optgroup="'+G+'"]').removeClass("selected");o.setSelected(r,true)}else{var q=typeof o.options.maxOptionsText==="string"?[o.options.maxOptionsText,o.options.maxOptionsText]:o.options.maxOptionsText,u=typeof q==="function"?q(J,A):q,I=u[0].replace("{n}",J),x=u[1].replace("{n}",A),B=g('<div class="notify"></div>');if(u[2]){I=I.replace("{var}",u[2][J>1?0:1]);x=x.replace("{var}",u[2][A>1?0:1])}E.prop("selected",false);o.$menu.append(B);
if(J&&s){B.append(g("<div>"+I+"</div>"));z=false;o.$element.trigger("maxReached.bs.select")}if(A&&v){B.append(g("<div>"+x+"</div>"));z=false;o.$element.trigger("maxReachedGrp.bs.select")}setTimeout(function(){o.setSelected(r,false)},10);B.delay(750).fadeOut(300,function(){g(this).remove()})}}}}}if(!o.multiple||(o.multiple&&o.options.maxOptions===1)){o.$button.focus()}else{if(o.options.liveSearch){o.$searchbox.focus()}}if(z){if((F!=o.$element.val()&&o.multiple)||(y!=o.$element.prop("selectedIndex")&&!o.multiple)){n=[r,E.prop("selected"),t];
o.$element.triggerNative("change")}}}});this.$menu.on("click","li.disabled a, .popover-title, .popover-title :not(.close)",function(q){if(q.currentTarget==this){q.preventDefault();q.stopPropagation();if(o.options.liveSearch&&!g(q.target).hasClass("close")){o.$searchbox.focus()}else{o.$button.focus()}}});this.$menuInner.on("click",".divider, .dropdown-header",function(q){q.preventDefault();q.stopPropagation();if(o.options.liveSearch){o.$searchbox.focus()}else{o.$button.focus()}});this.$menu.on("click",".popover-title .close",function(){o.$button.click()
});this.$searchbox.on("click",function(q){q.stopPropagation()});this.$menu.on("click",".actions-btn",function(q){if(o.options.liveSearch){o.$searchbox.focus()}else{o.$button.focus()}q.preventDefault();q.stopPropagation();if(g(this).hasClass("bs-select-all")){o.selectAll()}else{o.deselectAll()}});this.$element.change(function(){o.render(false);o.$element.trigger("changed.bs.select",n);n=null})},liveSearchListener:function(){var p=this,o=g('<li class="no-results"></li>');this.$button.on("click.dropdown.data-api",function(){p.$menuInner.find(".active").removeClass("active");
if(!!p.$searchbox.val()){p.$searchbox.val("");p.$lis.not(".is-hidden").removeClass("hidden");if(!!o.parent().length){o.remove()}}if(!p.multiple){p.$menuInner.find(".selected").addClass("active")}setTimeout(function(){p.$searchbox.focus()},10)});this.$searchbox.on("click.dropdown.data-api focus.dropdown.data-api touchend.dropdown.data-api",function(q){q.stopPropagation()});this.$searchbox.on("input propertychange",function(){p.$lis.not(".is-hidden").removeClass("hidden");p.$lis.filter(".active").removeClass("active");
o.remove();if(p.$searchbox.val()){var r=p.$lis.not(".is-hidden, .divider, .dropdown-header"),q;if(p.options.liveSearchNormalize){q=r.not(":a"+p._searchStyle()+'("'+c(p.$searchbox.val())+'")')}else{q=r.not(":"+p._searchStyle()+'("'+p.$searchbox.val()+'")')}if(q.length===r.length){o.html(p.options.noneResultsText.replace("{0}",'"'+m(p.$searchbox.val())+'"'));p.$menuInner.append(o);p.$lis.addClass("hidden")}else{q.addClass("hidden");var t=p.$lis.not(".hidden"),s;t.each(function(u){var v=g(this);if(v.hasClass("divider")){if(s===undefined){v.addClass("hidden")
}else{if(s){s.addClass("hidden")}s=v}}else{if(v.hasClass("dropdown-header")&&t.eq(u+1).data("optgroup")!==v.data("optgroup")){v.addClass("hidden")}else{s=null}}});if(s){s.addClass("hidden")}r.not(".hidden").first().addClass("active");p.$menuInner.scrollTop(0)}}})},_searchStyle:function(){var o={begins:"ibegins",startsWith:"ibegins"};return o[this.options.liveSearchStyle]||"icontains"},val:function(o){if(typeof o!=="undefined"){this.$element.val(o);this.render();return this.$element}else{return this.$element.val()
}},changeAll:function(p){if(!this.multiple){return}if(typeof p==="undefined"){p=true}this.findLis();var o=this.$element.find("option"),u=this.$lis.not(".divider, .dropdown-header, .disabled, .hidden"),q=u.length,t=[];if(p){if(u.filter(".selected").length===u.length){return}}else{if(u.filter(".selected").length===0){return}}u.toggleClass("selected",p);for(var r=0;r<q;r++){var s=u[r].getAttribute("data-original-index");t[t.length]=o.eq(s)[0]}g(t).prop("selected",p);this.render(false);this.togglePlaceholder();
this.$element.triggerNative("change")},selectAll:function(){return this.changeAll(true)},deselectAll:function(){return this.changeAll(false)},toggle:function(o){o=o||window.event;if(o){o.stopPropagation()}this.$button.trigger("click")},keydown:function(y){var z=g(this),t=z.is("input")?z.parent().parent():z.parent(),x,v=t.data("this"),w,r,A,q=":not(.disabled, .hidden, .dropdown-header, .divider)",s={32:" ",48:"0",49:"1",50:"2",51:"3",52:"4",53:"5",54:"6",55:"7",56:"8",57:"9",59:";",65:"a",66:"b",67:"c",68:"d",69:"e",70:"f",71:"g",72:"h",73:"i",74:"j",75:"k",76:"l",77:"m",78:"n",79:"o",80:"p",81:"q",82:"r",83:"s",84:"t",85:"u",86:"v",87:"w",88:"x",89:"y",90:"z",96:"0",97:"1",98:"2",99:"3",100:"4",101:"5",102:"6",103:"7",104:"8",105:"9"};
A=v.$newElement.hasClass("open");if(!A&&(y.keyCode>=48&&y.keyCode<=57||y.keyCode>=96&&y.keyCode<=105||y.keyCode>=65&&y.keyCode<=90)){if(!v.options.container){v.setSize();v.$menu.parent().addClass("open");A=true}else{v.$button.trigger("click")}v.$searchbox.focus();return}if(v.options.liveSearch){if(/(^9$|27)/.test(y.keyCode.toString(10))&&A){y.preventDefault();y.stopPropagation();v.$menuInner.click();v.$button.focus()}}if(/(38|40)/.test(y.keyCode.toString(10))){x=v.$lis.filter(q);if(!x.length){return
}if(!v.options.liveSearch){w=x.index(x.find("a").filter(":focus").parent())}else{w=x.index(x.filter(".active"))}r=v.$menuInner.data("prevIndex");if(y.keyCode==38){if((v.options.liveSearch||w==r)&&w!=-1){w--}if(w<0){w+=x.length}}else{if(y.keyCode==40){if(v.options.liveSearch||w==r){w++}w=w%x.length}}v.$menuInner.data("prevIndex",w);if(!v.options.liveSearch){x.eq(w).children("a").focus()}else{y.preventDefault();if(!z.hasClass("dropdown-toggle")){x.removeClass("active").eq(w).addClass("active").children("a").focus();
z.focus()}}}else{if(!z.is("input")){var o=[],u,B;x=v.$lis.filter(q);x.each(function(C){if(g.trim(g(this).children("a").text().toLowerCase()).substring(0,1)==s[y.keyCode]){o.push(C)}});u=g(document).data("keycount");u++;g(document).data("keycount",u);B=g.trim(g(":focus").text().toLowerCase()).substring(0,1);if(B!=s[y.keyCode]){u=1;g(document).data("keycount",u)}else{if(u>=o.length){g(document).data("keycount",0);if(u>o.length){u=1}}}x.eq(o[u-1]).children("a").focus()}}if((/(13|32)/.test(y.keyCode.toString(10))||(/(^9$)/.test(y.keyCode.toString(10))&&v.options.selectOnTab))&&A){if(!/(32)/.test(y.keyCode.toString(10))){y.preventDefault()
}if(!v.options.liveSearch){var p=g(":focus");p.click();p.focus();y.preventDefault();g(document).data("spaceSelect",true)}else{if(!/(32)/.test(y.keyCode.toString(10))){v.$menuInner.find(".active a").click();z.focus()}}g(document).data("keycount",0)}if((/(^9$|27)/.test(y.keyCode.toString(10))&&A&&(v.multiple||v.options.liveSearch))||(/(27)/.test(y.keyCode.toString(10))&&!A)){v.$menu.parent().removeClass("open");if(v.options.container){v.$newElement.removeClass("open")}v.$button.focus()}},mobile:function(){this.$element.addClass("mobile-device")
},refresh:function(){this.$lis=null;this.liObj={};this.reloadLi();this.render();this.checkDisabled();this.liHeight(true);this.setStyle();this.setWidth();if(this.$lis){this.$searchbox.trigger("propertychange")}this.$element.trigger("refreshed.bs.select")},hide:function(){this.$newElement.hide()},show:function(){this.$newElement.show()},remove:function(){this.$newElement.remove();this.$element.remove()},destroy:function(){this.$newElement.before(this.$element).remove();if(this.$bsContainer){this.$bsContainer.remove()
}else{this.$menu.remove()}this.$element.off(".bs.select").removeData("selectpicker").removeClass("bs-select-hidden selectpicker")}};function k(q){var o=arguments;var s=q;[].shift.apply(o);var r;var p=this.each(function(){var x=g(this);if(x.is("select")){var w=x.data("selectpicker"),u=typeof s=="object"&&s;if(!w){var t=g.extend({},l.DEFAULTS,g.fn.selectpicker.defaults||{},x.data(),u);t.template=g.extend({},l.DEFAULTS.template,(g.fn.selectpicker.defaults?g.fn.selectpicker.defaults.template:{}),x.data().template,u.template);
x.data("selectpicker",(w=new l(this,t)))}else{if(u){for(var v in u){if(u.hasOwnProperty(v)){w.options[v]=u[v]}}}}if(typeof s=="string"){if(w[s] instanceof Function){r=w[s].apply(w,o)}else{r=w.options[s]}}}});if(typeof r!=="undefined"){return r}else{return p}}var d=g.fn.selectpicker;g.fn.selectpicker=k;g.fn.selectpicker.Constructor=l;g.fn.selectpicker.noConflict=function(){g.fn.selectpicker=d;return this};g(document).data("keycount",0).on("keydown.bs.select",'.bootstrap-select [data-toggle=dropdown], .bootstrap-select [role="listbox"], .bs-searchbox input',l.prototype.keydown).on("focusin.modal",'.bootstrap-select [data-toggle=dropdown], .bootstrap-select [role="listbox"], .bs-searchbox input',function(o){o.stopPropagation()
});g(window).on("load.bs.select.data-api",function(){g(".selectpicker").each(function(){var o=g(this);k.call(o,o.data())})})})(a)}));


function DVelop_WorkWithPlusUtilities() {
	this.Width;
	this.Height;
	this.EnableAutoUpdateFromDocumentTitle;
	this.EnableFixObjectFitCover;
	this.EnableFloatingLabels;
	this.EnableConvertComboToBootstrapSelect;
	this.AutoUpdateFromDocumentTitle_Enabled;
	this.CurrentTab_ReturnUrl;

	this.show = function () {
		SetMinWidthTotalizers();
		if (this.EnableFloatingLabels) {
			this.FloatingLabels();
		}
		if (this.EnableConvertComboToBootstrapSelect) {
			this.ApplyBootstrapSelect();
		}

		if (this.EnableAutoUpdateFromDocumentTitle && !this.AutoUpdateFromDocumentTitle_Enabled) {
			//Automatically update textblocks with the form caption
			this.AutoUpdateFromDocumentTitle_Enabled = true;
			var target = document.querySelector('head > title');
			var MutationObserver = window.MutationObserver || window.WebKitMutationObserver || window.MozMutationObserver;
			var observer = new MutationObserver(function (mutations) {
				mutations.forEach(function (mutation) {
					$('.AutoUpdateFromDocumentTitle').text(mutation.target.textContent)
				});
			});
			observer.observe(target, { subtree: true, characterData: true, childList: true });
		}

		gx.fx.obs.addObserver("gx.onafterevent", window, function (thisC) {
			return function (e) {
				SetMinWidthTotalizers();
				if (thisC.EnableFloatingLabels) {
					thisC.FloatingLabels();
				}
				if (thisC.EnableFixObjectFitCover && thisC.IsIE()) {
					thisC.FixObjectFitCover();
				}
				if (thisC.EnableConvertComboToBootstrapSelect) {
					thisC.ApplyBootstrapSelect();
				}
			}
		}(this));

		gx.fx.obs.addObserver("grid.onafterrender", window, function (thisC) {
			return function (e) {
				if (thisC.EnableConvertComboToBootstrapSelect) {
					thisC.ApplyBootstrapSelect();
				}
			}
		}(this));

		gx.fx.obs.addObserver("gx.onload", window, function (thisC) {
			return function (e) {
				SetMinWidthTotalizers();
				if (thisC.EnableFloatingLabels) {
					thisC.FloatingLabels();
				}
				if (thisC.EnableFixObjectFitCover && thisC.IsIE()) {
					thisC.FixObjectFitCover();
				}
				if (thisC.EnableConvertComboToBootstrapSelect) {
					thisC.ApplyBootstrapSelect();
				}
			}
		}(this));
		if (window.frameElement != null && window.frameElement.urlHist != null && window.frameElement.urlHist.length > 0) {
			this.CurrentTab_ReturnUrl = window.frameElement.urlHist[window.frameElement.urlHist.length - 1];
			var currentLocation = window.frameElement.contentWindow.location + '';
			if (currentLocation.indexOf('#') >= 0) {
				var currentTab_ReturnUrlVal = this.CurrentTab_ReturnUrl;
				if (currentTab_ReturnUrlVal.indexOf('#') >= 0) {
					currentTab_ReturnUrlVal = currentTab_ReturnUrlVal.substring(0, currentTab_ReturnUrlVal.indexOf('#'));
				}
				if (currentLocation.startsWith(currentTab_ReturnUrlVal)) {
					this.CurrentTab_ReturnUrl = currentLocation;
					window.frameElement.urlHist[window.frameElement.urlHist.length - 1] = this.CurrentTab_ReturnUrl;
				}
			}
		}
	}

	this.CurrentTab_Return = function () {
		if (window.frameElement != null && window.frameElement.urlHist != null && window.frameElement.urlHist.length > 1) {
			window.frameElement.urlHist.splice(window.frameElement.urlHist.length - 2, 2);
		}
	}

	this.IsIE = function () {
		return (window.navigator.userAgent.indexOf("MSIE ") >= 0 || (!!window.MSInputMethodContext && !!document.documentMode));
	}

	this.FixObjectFitCover = function () {
		if (this.IsIE()) {
			$("img.ObjectFitCover").each(function (i) {
				if (this.getAttribute('src') != '') {
					$(this).css('background-image', "url('" + this.getAttribute('src') + "')");
					$(this).addClass('ObjectFitCoverFix');
					this.setAttribute('src', '');
				}
			});
		}
	}

	this.FloatingLabels = function () {
		var thisC = this;
		$(".AttributeFL>input:checkbox").on("click", function (i) {
			$(".AttributeFL").each(function (i) {
				thisC.FloatingLabels_AnimateLabel(this, null);
			});
			window.setTimeout(function () {
				thisC.FloatingLabels_WatchReadonlyAttributes();
			}, 100);
		});
		$(".ReadonlyAttributeFL>input:checkbox").each(function (i) {
			thisC.FloatingLabels_AnimateLabel_ToggleClases(this, true, false);
		});
		$("img.ReadonlyAttributeFL").each(function (i) {
			thisC.FloatingLabels_AnimateLabel_ToggleClases(this, true, false);
		});
		$(".AttributeFL").each(function (i) {
			if (!thisC.FloatingLabels_IsEventBound(this)) {
				$(this).on("focus blur", function (i) {
					thisC.FloatingLabels_AttributeFocused(this, i);
				});
			}
			if (thisC.IsIE() && (($(this).get(0).onblur + '' + $(this).get(0).onchange).indexOf('gx.date.') >= 0 || $(this).parent().find('.gx-image-link').length > 0)) {
				$(this).parent().parent().unbind("DOMSubtreeModified").bind("DOMSubtreeModified", function () {
					var elem = $(this).find(".AttributeFL").get(0);
					if (elem != null && !thisC.FloatingLabels_IsEventBound(elem)) {
						$(elem).on("focus blur", function (i) {
							thisC.FloatingLabels_AttributeFocused(this, i);
						});
					}
				});
			}
			thisC.FloatingLabels_AnimateLabel(this, null);
			thisC.FloatingLabels_WatchReadonlyAttribute(this);
		});
	}

	this.FloatingLabels_IsEventBound = function (elem) {
		var type = 'focus';
		var datas = jQuery._data(elem, 'events');
		if (datas != null) {
			var data = jQuery._data(elem, 'events')[type];

			if (data === undefined || data.length === 0) {
				return false;
			}
			for (var i = 0; i < data.length ; i++) {
				if ((data[i].handler + ' ').indexOf('FloatingLabels_AttributeFocused') >= 0) {
					return true;
				}
			}
		}

		return false;
	}

	this.FloatingLabels_AttributeFocused = function (elem, i) {
		var thisC = this;
		//console.log(elem.name);

		if ("focus" === i.type) {
			$(".AttributeFL").each(function (i) {
				thisC.FloatingLabels_AnimateLabel(this, null);
			});
		}
		else {
			this.FloatingLabels_WatchReadonlyAttributes();
		}
		this.FloatingLabels_AnimateLabel(elem, i);
	}

	this.FloatingLabels_WatchReadonlyAttributes = function () {
		var thisC = this;
		$(".ReadonlyAttributeFL, .Readonlyform-control.AttributeFL").each(function (i) {
			var elem = $(this).parents(".form-group").find(".AttributeFL:not(.Readonlyform-control)").get(0);
			if (elem != null) {
				thisC.FloatingLabels_WatchReadonlyAttribute(elem);
			}
		});
	}

	this.FloatingLabels_WatchReadonlyAttribute = function (inputElem) {
		var thisC = this;
		$(inputElem).parents(".form-group").find(".ReadonlyAttributeFL, .Readonlyform-control.AttributeFL").parent().unbind("DOMSubtreeModified").bind("DOMSubtreeModified", function () {
			var elem = $(this).parents(".form-group").find(".AttributeFL:not(.Readonlyform-control)").get(0);
			if (elem != null) {
				if ($(elem.parentNode).find('span').length == 0) {
					setTimeout(function () { thisC.FloatingLabels_AnimateLabel(elem, null); }, 200);
				} else {
					thisC.FloatingLabels_AnimateLabel(elem, null);
				}
			}
			if (this.tagName != 'P') {
				$(this).unbind("DOMSubtreeModified");
				$(this).find(".ReadonlyAttributeFL, .Readonlyform-control.AttributeFL").parent().unbind("DOMSubtreeModified").bind("DOMSubtreeModified", function () {
					var elem = $(this).parents(".form-group").find(".AttributeFL:not(.Readonlyform-control)").get(0);
					if (elem != null) {
						thisC.FloatingLabels_AnimateLabel(elem, null);
					}
				});
			}
		});
	}

	this.FloatingLabels_AnimateLabel = function (elem, i) {
		var controlValue;
		var isDate = ($(elem).get(0).onblur + '' + $(elem).get(0).onchange).indexOf('gx.date.') >= 0;
		if (isDate) {
			controlValue = $(elem).val().replace('/', '').replace('/', '').trim();
		}
		else {
			if (elem.tagName == 'SELECT') {
				controlValue = $(elem).find('option:selected').text();
			}
			else {
				controlValue = elem.value;
				if (controlValue == '0' && ($(elem).get(0).onblur + '' + $(elem).get(0).onchange).indexOf('gx.num.') >= 0) {
					controlValue = '';
				}
			}
		}
		var addReadOnly = false;
		if (!$(elem.parentNode).is(":visible")) {
			addReadOnly = ($(elem).css('display') == 'none') && $($(elem).parents(".gx-attribute").find('span')).css('display') != 'none';
		}
		else {
			addReadOnly = $(elem).hasClass('ReadonlyExtendedCombo') || (!$(elem).is(":visible")) && $(elem).parents(".gx-attribute").find('span').is(":visible");
		}
		addReadOnly = addReadOnly && (elem.id == null || !elem.id.match(/_GXI$/));
		var addEmptyVal = !addReadOnly
							&& elem.type != 'checkbox'
							&& (elem.tagName != 'SPAN' || $(elem).find('>input[type=checkbox]').length == 0)
							&& elem.type != 'file'
							&& elem.type != 'textarea'
							&& elem.tagName != 'IMG'
							&& !$(elem).hasClass('gx-radio-button')
							&& elem.tagName != 'LABEL'
							&& (elem.id == null || !elem.id.match(/_GXI$/))
							&& !(i != null && "focus" === i.type || controlValue != null && controlValue.length > 0 || $(elem).is(':focus'));
		this.FloatingLabels_AnimateLabel_ToggleClases(elem, addReadOnly, addEmptyVal);
	}

	this.FloatingLabels_AnimateLabel_ToggleClases = function (elem, addReadOnly, addEmptyVal) {
		if ($(elem).hasClass('ReadonlyExtendedCombo')) {
			var isMergeDataCell = $(elem.parentNode.parentNode).hasClass('MergeDataCell')
									&& $(elem.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.previousSibling).hasClass('MergeLabelCell');
			if (isMergeDataCell) {
				$(elem.parentNode.parentNode.parentNode.parentNode.parentNode.parentNode.previousSibling).addClass("FloatingLabelReadonly").find('span.Label').addClass('AttributeFLLabel').addClass('control-label');
				$(elem.parentNode.parentNode.parentNode.parentNode.parentNode).addClass("TableMergedReadonlyExtendedCombo");
			} else {
				if ($(elem.parentNode.parentNode.previousSibling).hasClass('MergeLabelCell')) {
					$(elem.parentNode.parentNode.previousSibling).addClass("FloatingLabelReadonly").find('span.Label').addClass('AttributeFLLabel').addClass('control-label');
				}
			}

		} else if ($(elem).hasClass('ExtendedCombo')) {
			var isMergeDataCell = $(elem.parentNode).hasClass('MergeDataCell')
									&& $(elem.parentNode.parentNode.parentNode.parentNode.parentNode.previousSibling).hasClass('MergeLabelCell');
			if (isMergeDataCell) {
				$(elem.parentNode.parentNode.parentNode.parentNode).addClass("TableMergedExtendedCombo");
			}

		} else {
			var isMergeDataCell = $(elem).parents(".gx-attribute").length == 1
									&& $($(elem).parents(".gx-attribute").get(0).parentNode).hasClass('MergeDataCell')
									&& $($(elem).parents(".gx-attribute").get(0).parentNode.parentNode.parentNode.parentNode.parentNode.previousSibling).hasClass('MergeLabelCell');
			if (isMergeDataCell) {
				var gxAttElem = $(elem).parents(".gx-attribute").get(0);
				$(gxAttElem.parentNode).toggleClass("FloatingLabelEmpty", addEmptyVal);
				$(gxAttElem.parentNode).toggleClass("FloatingLabelReadonly", addReadOnly);
				$(gxAttElem.parentNode.parentNode.parentNode.parentNode.parentNode.previousSibling).toggleClass("FloatingLabelEmpty", addEmptyVal).toggleClass("FloatingLabelReadonly", addReadOnly).find('span.Label').addClass('AttributeFLLabel').addClass('control-label');
			}
			else {
				$(elem).parents(".form-group").toggleClass("FloatingLabelEmpty", addEmptyVal).toggleClass("FloatingLabelReadonly", addReadOnly);
			}
		}
	}

	//ApplyBootstrapSelect - Start
	this.ApplyBootstrapSelect = function () {
		var thisC = this;
		$('select.ConvertToDDO').each(function (g, h) {
			if (!$(h).hasClass("selectpicker")) {
				var c = $(h);

				c.addClass("selectpicker").selectpicker({
					noneSelectedText: "",
					showContent: false
				});

				c.on('show.bs.select', function (e, clickedIndex, isSelected, previousValue) {
					$(this).focus();
				});

				thisC.ApplyBootstrapSelect_updateDDO(h);

				c = c.parent();
				c.on("changed.bs.select", function (j, i, l, k) {
					if ($(this).find('>select').hasClass('selectpicker')) {
						$(this).css('display', 'none');
						var thisC2 = this;
						window.setTimeout(function () {
							$(j.target).val(0);
							$(j.target).selectpicker("refresh");
							thisC.ApplyBootstrapSelect_updateDDO(thisC2);
							$(thisC2).css('display', '');
						}, 100);
					}
				});
				c.bind('hidden.bs.dropdown', function (thisC) {
					return function (e) {
						thisC.ApplyBootstrapSelect_setSectionGridMinHeight(e.target, false);
					}
				}(thisC));
				c.bind('shown.bs.dropdown', function (thisC) {
					return function (e) {
						thisC.ApplyBootstrapSelect_setSectionGridMinHeight(e.target, true);
					}
				}(thisC));
			}
		})
	}
	this.ApplyBootstrapSelect_updateDDO = function (h) {
		var c = $(h).parent();
		c.find("[data-original-index=0]").hide();

		var btn = c.find("button").get(0);
		var btnCaptionSpan = c.find("button > span").get(0);
		if (btnCaptionSpan != null && btnCaptionSpan.innerText.indexOf(';') >= 0) {
			if (btnCaptionSpan.parentNode.childNodes[0].tagName != 'I') {
				$("<i class='" + btnCaptionSpan.innerText.substring(btnCaptionSpan.innerText.indexOf(';') + 1) + "'></i>").insertBefore(btnCaptionSpan);
			}
			btnCaptionSpan.innerText = btnCaptionSpan.innerText.substring(0, btnCaptionSpan.innerText.indexOf(';'));
		}
		btn.title = '';

		c.find("li").each(function (g2, h2) {
			var data1 = h2.childNodes[0];
			if (data1.childNodes[0].tagName != 'I' && data1.childNodes[0].innerText.indexOf(';') >= 0) {
				var data1_i = document.createElement('i');
				data1_i.className = data1.childNodes[0].innerText.substring(data1.childNodes[0].innerText.indexOf(';') + 1);
				data1.childNodes[0].innerText = data1.childNodes[0].innerText.substring(0, data1.childNodes[0].innerText.indexOf(';'));
				data1.insertBefore(data1_i, data1.childNodes[0]);
			}
		});
	}
	this.ApplyBootstrapSelect_setSectionGridMinHeight = function (ddo, setMinHeight) {
		var ul = $(ddo).find('.dropdown-menu > ul').get(0);
		var sectionGridElement = ul;
		for (var i = 0; i < 15; i++) {
			if ($(sectionGridElement).hasClass("SectionGrid")) {
				break;
			}
			else {
				sectionGridElement = sectionGridElement.parentElement;
			}
		}
		if ($(sectionGridElement).hasClass("SectionGrid")) {
			var overflowEl = sectionGridElement.children[0];
			if (setMinHeight) {
				var minH = $(ul).offset().top - $(overflowEl).offset().top + ul.offsetHeight + 16;//12 = shadow
				$(overflowEl).css({ 'min-height': minH + "px" });
				if ($(overflowEl).height() > overflowEl.scrollHeight) {
					//has horizontal scroll visible
					minH += $(overflowEl).height() - overflowEl.scrollHeight;
					$(overflowEl).css({ 'min-height': minH + "px" });
				}
			}
			else {
				$(overflowEl).css({ 'min-height': "" });
			}
		}
	}
	//ApplyBootstrapSelect - End
}

function WWPSelectAll(allBox, upperSelectFilterName) {
	for (var i = 0; i < document.MAINFORM.elements.length; i++) {
		var e = document.MAINFORM.elements[i];

		if (e.type == 'checkbox' && e.name != allBox.name && e.name.toUpperCase().indexOf(upperSelectFilterName) >= 0) {
			e.parentNode.click();
			e.checked = allBox.checked;
		}
	}
}

function WWPSelectAllGXUI(allSelectedVariable) {
	if (document.getElementById(allSelectedVariable).value == 'true') {
		document.getElementById(allSelectedVariable).value = 'false';
	} else {
		document.getElementById(allSelectedVariable).value = 'true';
	}
	WWPDoGXRefresh();
}

function WWPSelectAllRemoveParentOnClick(allBox) {
	allBox.parentNode.onclick = '';
}

function WWPSortColumn(orderAscId, orderById, orderIndex) {
	var selOrderIndex;
	if (orderById != '') {
		selOrderIndex = document.getElementById(orderById).value;
	} else {
		selOrderIndex = orderIndex;
	}
	if (selOrderIndex == orderIndex) {
		if (document.getElementById(orderAscId).value == 'true') {
			document.getElementById(orderAscId).value = 'false';
		} else {
			document.getElementById(orderAscId).value = 'true';
		}
	} else {
		document.getElementById(orderById).value = orderIndex;
	}
	var wcName = '';
	if (orderAscId != null && orderAscId.indexOf("vORDEREDDSC") > 0) {
		wcName = orderAscId.substring(0, orderAscId.indexOf("vORDEREDDSC"));
	}
	WWPDoGXRefresh(wcName);
}

function WWPDoGXRefresh() {
	WWPDoGXRefresh('');
}

function WWPDoGXRefresh(wcName) {
	if (wcName == null) {
		wcName = '';
	}
	gx.evt.execEvt(wcName, false, wcName + 'EREFRESH.', this);
}

function WWPDynFilterHideLast(lastIndex) {
	while (lastIndex > 1) {
		if (document.getElementById('Dynamicfiltersrow' + lastIndex).className != 'Invisible') {
			document.getElementById('Dynamicfiltersrow' + lastIndex).className = 'Invisible';
			return true;
		}
		lastIndex--;
	}
	return true;
}

function WWPDynFilterHideLast_AL(dynTableId, lastIndex, fixedFilters) {
	while (lastIndex > 1) {
		var row = document.getElementById(dynTableId).rows[lastIndex + fixedFilters - 1];
		if (row.cells[0].className.indexOf('Invisible') == -1) {
			for (var i = 0, cell; cell = row.cells[i]; i++) {
				cell.className = 'Invisible';
			}
			return true;
		}
		lastIndex--;
	}
	return true;
}


function WWPDynFilterShow(index) {
	document.getElementById('Dynamicfiltersrow' + index).className = '';
	return true;
}

function WWPDynFilterShow_AL(dynTableId, index, fixedFilters) {
	var row = document.getElementById(dynTableId).rows[index + fixedFilters - 1];
	var firstRow = document.getElementById(dynTableId).rows[fixedFilters];
	for (var i = 0, cell; cell = row.cells[i]; i++) {
		cell.className = firstRow.cells[i].className;
	}
	return true;
}

function WWPDynFilterHideAll(totalRows) {
	while (totalRows > 1) {
		if (document.getElementById('Dynamicfiltersrow' + totalRows).className != 'Invisible') {
			document.getElementById('Dynamicfiltersrow' + totalRows).className = 'Invisible';
		}
		totalRows--;
	}
	return true;
}

function WWPDynFilterHideAll_AL(dynTableId, totalRows, fixedFilters) {
	while (totalRows > 1) {
		var row = document.getElementById(dynTableId).rows[totalRows + fixedFilters - 1];
		if (row.cells[0].className.indexOf('Invisible') == -1) {
			for (var i = 0, cell; cell = row.cells[i]; i++) {
				cell.className = 'Invisible';
			}
		}
		totalRows--;
	}
	return true;
}

function SetMinWidthTotalizers() {

	$("table.GridWithTotalizer").each(function () {;
		var idGrid = $(this).attr('id');
		var tableTotalizerId = idGrid.substring(0, idGrid.indexOf("ContainerTbl")).toUpperCase() + "TABLETOTALIZER";
		if ($(this).css('display') == 'none') {
			$("#" + tableTotalizerId).css({ display: 'none' });
		} else {
			$("#" + tableTotalizerId).css({ display: '' });
		}
		var width = $(this).outerWidth();
		if ($("#" + tableTotalizerId).hasClass("TableTotalizerAl")) {
			width = width - parseInt($("#" + tableTotalizerId).css('margin-left')) - parseInt($("#" + tableTotalizerId).css('margin-right'));
			$("#" + tableTotalizerId).css({ minWidth: width });
		}

		var i = 0;
		$('#' + idGrid).find('th.GridWithTotalizer').each(function () {
			var widthTH = $(this).outerWidth();
			var item = $("#" + tableTotalizerId + " td")[i];
			$(item).css({ width: widthTH });
			if ($(this).css('display') == 'none')
				$(item).css({ display: 'none' });
			else
				$(item).css({ display: 'table-cell' });
			var textAl = $(this).css('text-align');
			if (textAl != null && textAl != '')
				$(item).css({ 'text-align': textAl });
			i++;
		});
	});
}

function ClearMinWidthTotalizers() {
	$("table.GridWithTotalizer").each(function () {;
		var idGrid = $(this).attr('id');
		var tableTotalizerId = idGrid.substring(0, idGrid.indexOf("ContainerTbl")).toUpperCase() + "TABLETOTALIZER";
		if ($("#" + tableTotalizerId).hasClass("TableTotalizerAl"))
			$("#" + tableTotalizerId).css({ minWidth: 0 });

		var i = 0;
		$('#' + idGrid).find('th.GridWithTotalizer').each(function () {
			var item = $("#" + tableTotalizerId + " td")[i];
			$(item).css({ width: 0 });
			if ($(this).css('display') == 'none')
				$(item).css({ display: 'none' });
			else
				$(item).css({ display: 'table-cell' });
			i++;
		});
	});
}

$(window).resize(function () {
	SetMinWidthTotalizers();
});

$(window).load(function () {
	SetMinWidthTotalizers();
});



