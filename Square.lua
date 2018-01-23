script_name("Squares Map By Kotik Wilson")
script_version("1.1")
script_author("Kotik_prikol and Laine_prikol")

require"lib.moonloader"

function Territory()
	local Square = { '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�', '�' }
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
	sampAddChatMessage("Squares Map: ������� ��������� ���� ������������...", 0xCCFFDD56)
	local file = io.open("moonloader/Squares_Map.cfg", "r")
	if file == nil then
		sampAddChatMessage("Squares Map: ��������� ������: �� ������� ��������� ���� ������������!!!", 0xCCFFDD56)
	else
		message = file:read("*a")
		sampAddChatMessage("Squares Map: ���� ������������ ��������!", 0xCCFFDD56)
		sampAddChatMessage("Squares Map v.1.1 By Kotik Wilson and Laine_prikol", 0xCCFFDD56)
	end
    while true do
        wait(0)
        if isKeyDown(219) then
            sampSendChat("/f "..message..", � � ��������: "..Territory())
            while isKeyDown(219) do wait(100) end
        end
    end
end