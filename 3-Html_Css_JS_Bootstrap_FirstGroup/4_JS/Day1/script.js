        function displayWelcomeMessage()
        {
            let name = document.getElementById("userInput").value;

            if(name.trim() === "")
            {
                document.getElementById("result").innerText="pls Enter Name First";
            }
            else
            {
                document.getElementById("result").innerText=`Welcome , ${name} `;
            }
        }