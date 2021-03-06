        Dim contacts As XElement = 
        <contacts>
            <contact>
                <name>Patrick Hines</name>
                <phone type="home">206-555-0144</phone>
                <phone type="work">425-555-0145</phone>
            </contact>
        </contacts>

        Console.WriteLine("Name: " & contacts...<name>.Value)

        Dim phoneTypes As XElement = 
          <phoneTypes>
              <%= From phone In contacts...<phone> 
                  Select <type><%= phone.@type %></type> 
              %>
          </phoneTypes>

        Console.WriteLine(phoneTypes)