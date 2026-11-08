import 'package:flutter/material.dart';

class Examplepage1 extends StatelessWidget {
  const Examplepage1({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          Center(
            child: Image.asset(
              'assets/Images/f3.jpg',
              width: 250,
              height: 250,
            ),
          ),
          Center(
            child: Image.network(
              'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS-SmX4r9PqcGnGPwacyYSQYLojk85juniI4A&s',
            width: 250,
            height: 250,),
          )
        ],
      ),
    );
  }
}
