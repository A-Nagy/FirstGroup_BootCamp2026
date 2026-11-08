import 'package:firstgroup_mobileapp/AllWidgets/ExamplePage4.dart';
import 'package:firstgroup_mobileapp/AllWidgets/progressExamples.dart';
 import 'package:flutter/material.dart';

void main()
{
runApp(const MyApp());
}

class MyApp extends StatelessWidget
{
  const MyApp({super.key});
  @override
  Widget build(BuildContext context) {
    return  MaterialApp(
      debugShowCheckedModeBanner: false,
      title:'Flutter Demo',
      home : progressIndector() ,

    );
  }
}

