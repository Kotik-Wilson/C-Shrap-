script_name("Squares Map By Kotik Wilson")
script_version("1.1")
script_author("Kotik_prikol and Laine_prikol")

require"lib.moonloader"

function Territory()
	local Square = { 'А', 'Б', 'В', 'Г', 'Д', 'Ж', 'З', 'И', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Я' }
    local X, Y, Z = getCharCoordinates(playerPed)
    X = math.ceil((X + 3000) / 250)
    Y = math.ceil((Y * - 1 + 3000) / 250)
    Y = Square[Y]
    local Squares = (Y.."-"..X)
    return Squares
end

function main()
    if not isSampfuncsLoaded() or not isSampLoaded() then return end
    while not isSampAvailable() do wait(100) end
	sampAddChatMessage("Squares Map: Попытка загрузить файл конфигурации...", 0xCCFFDD56)
	local file = io.open("moonloader/Squares_Map.cfg", "r")
	if file == nil then
		sampAddChatMessage("Squares Map: Фатальная ошибка: Не удолось загрузить файл конфигурации!!!", 0xCCFFDD56)
	else
		message = file:read("*a")
		sampAddChatMessage("Squares Map: Файл конфигурации загружен!", 0xCCFFDD56)
		sampAddChatMessage("Squares Map v.1.1 By Kotik Wilson and Laine_prikol", 0xCCFFDD56)
	end
    while true do
        wait(0)
        if isKeyDown(219) then
            sampSendChat("/f "..message..", я в квадрате: "..Territory())
            while isKeyDown(219) do wait(100) end
        end
    end
end