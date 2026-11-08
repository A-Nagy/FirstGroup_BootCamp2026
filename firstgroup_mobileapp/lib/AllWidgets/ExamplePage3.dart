import 'package:flutter/material.dart';

class Examplepage3 extends StatefulWidget {
  const Examplepage3({super.key});

  @override
  State<Examplepage3> createState() => _Examplepage3State();
}

class _Examplepage3State extends State<Examplepage3> {
  int Counter = 1 ;
  @override
  void initState() {
    super.initState();
  }
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Text(
              'Counter : ${Counter}',
              style: TextStyle(
                fontSize: 60 ,
                fontWeight: FontWeight.bold
              ),
            ),
            ElevatedButton(
                onPressed: (){
                  setState(() {
                    Counter ++ ;
                  });
                 
                }, child: Icon(Icons.add)),
            ElevatedButton(
                onPressed: (){
                  setState(() {
                    Counter -- ;
                  });

                }, child: Text('-'))
          ],
        ),
      ),
    );
  }
}
