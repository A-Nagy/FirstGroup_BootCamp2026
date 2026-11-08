import 'package:flutter/material.dart';
import 'package:flutter/cupertino.dart';

class Scaffoldexample extends StatelessWidget
{
  const Scaffoldexample({super.key});
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      drawer: const Drawer(),
      endDrawer: const Drawer(),
      appBar: AppBar(
        title: Text('Home',
          style: TextStyle(
              fontSize: 28,
              fontWeight: FontWeight.bold,
              color: Colors.white
          ),),
        centerTitle: true,
        //leading:Icon(Icons.arrow_back) ,
        
        backgroundColor: Colors.blue,
        foregroundColor: Colors.white,
      ),
      body:Container(
          margin: EdgeInsets.symmetric(vertical: 50 , horizontal: 50),
          padding: EdgeInsets.all(40),
          //color: Colors.greenAccent,
          decoration: BoxDecoration(
            gradient: const SweepGradient(
                colors: [
                  Colors.blue,
                  Colors.greenAccent,
                  Colors.red,
                  Colors.green
                ]
            ),
            color: Colors.black,
            boxShadow: const [
              BoxShadow(
                color: Colors.purple,
                blurRadius: 10.0,
                offset: Offset(10,10)
              ),
              BoxShadow(
                  color: Colors.purple,
                  blurRadius: 10.0,
                  offset: Offset(-10,-10)
              )
            ],
             borderRadius: BorderRadius.circular(50)),
          child:Text(
            'Welcome TO Flutter',
            style: TextStyle(
                fontSize: 24,
                fontWeight: FontWeight.bold,
                color: Colors.white
            ),
          ) ,
        ),
      backgroundColor:Colors.amber ,
      floatingActionButton:Container(
        color: Colors.red,
        height: 80,
        width: 80,
        child:Center(
            child: const Text('Press')),
      ) ,
      bottomNavigationBar:Container(
        color: Colors.blue,
        height: 80,
      ) ,


    );
  }
}