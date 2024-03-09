print("This Game Id is : "..game.gameId)
local e = request or http_request
local a = e({
    Url = "https://raw.githubusercontent.com/Colorful-Hub/ColorfulHub/main/"..game.gameId..".lua",
    Method = "GET"
})
if a.StatusCode == 200 then
    loadstring(a.Body)()
else
    game.Players.LocalPlayer:Kick("\n Not Have This Game")
end
