import { AfterContentInit, Component, OnInit } from '@angular/core';
import { WebAssemblyTestNameSpace } from '../assets/dotnet';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit, AfterContentInit {
  ngAfterContentInit(): void {
  }
  ngOnInit(): void {
    
  }
  testWebAssembly():void{
     var val = WebAssemblyTestNameSpace.ChangeDtoIdTo2(
      "assets\\dotnet.js",
      "23520091-81a3-4237-b633-64e41020dcc2",
      {name:"name", id:123});
     console.log("return value: ", val);
  }


  title = 'WebAssemplyDemo';

}
