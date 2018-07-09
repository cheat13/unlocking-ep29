import { Component, wtfStartTimeRange } from '@angular/core';
import { NavController } from 'ionic-angular';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/timeout';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  score : any;
  result : any;

  constructor(public navCtrl: NavController, public http: Http) {
    this.result = "Your grade";
  }

  CalculateGrade()
  {
    if(this.score != null && this.score != "" && this.score >= 0 && this.score <= 100)
    {
      this.result = "Please wait...";
      let path = 'https://calculator29.azurewebsites.net/api/calculator/grade/'+ this.score;
      let timeoutMS = 10000;
      this.http.get(path)
               .timeout(timeoutMS)
               .map(res => res.json())
               .subscribe(data => {
                  this.result = data.grade;
                },err => {
                  this.result = "Error is ocured please try again." + err
                });
    }
    else
    {
      this.result = "Please input number 0 - 100!"
    }
  }
}
